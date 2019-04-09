using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GISConvert
{
    public class Converter
    {
        public List<PipeClass> pipes = new List<PipeClass>();
        public List<PktClass> coordinates = new List<PktClass>();
        public List<PktClass> vertices = new List<PktClass>();
        

        private string path
        {
            get {
                return ConfigurationManager.AppSettings["path"].ToString();
            }
        }

        public Converter()
        {
            fillPipeList();

            fillVertList();

            saveToFile();
        }

        private void saveToFile()
        {
            using (StreamWriter sw = new StreamWriter(path + "file.inp"))
            {
                sw.WriteLine("[JUNCTIONS]");
                foreach (PktClass p in coordinates)
                {
                    sw.WriteLine($"{p.NODE}\t0\t0");
                }

                sw.WriteLine("[PIPES]");
                foreach (PipeClass p in pipes)
                {
                    sw.WriteLine( $"{p.ID}\t{p.Node1}\t{p.Node2}\t{p.Lenght}\t{p.Diameter}\t{p.Roughness}\t{p.MionorLoss}\t{p.Status}");
                }

                sw.WriteLine("[COORDINATES]");
                foreach (PktClass c in coordinates)
                {
                    sw.WriteLine( $"{c.NODE}\t{c.X_Coord}\t{c.Y_Coord}");
                }

                sw.WriteLine("[VERTICES]");
                foreach (PktClass v in vertices)
                {
                    sw.WriteLine($"{v.NODE}\t{v.X_Coord}\t{v.Y_Coord}");
                }

            }
        }
        
        private void fillVertList()
        {
            StreamReader file = new System.IO.StreamReader(path + "wezelOsowa.geojson");
            string content = file.ReadToEnd();
            file.Close();

            dynamic deserialized = JsonConvert.DeserializeObject(content);

            foreach (var item in deserialized.features)
            {
                JArray o = JArray.Parse(item.geometry.coordinates.ToString());

            
                    double x = double.Parse(item.geometry.coordinates[0].ToString());
                    double y = double.Parse(item.geometry.coordinates[1].ToString());
                    int mslink = int.Parse( item.properties["MSLINK"].ToString());
                    
                    coordinates.Add(new PktClass( mslink, x, y));
            }

            //foreach (var item in coordinates)
            //{
            //    item.print();
            //}

        }

        private void fillPipeList()
        {
            StreamReader file = new System.IO.StreamReader(path + "siec_wodOsowa.geojson");
            string content = file.ReadToEnd();
            file.Close();
            
            dynamic deserialized = JsonConvert.DeserializeObject(content);

            foreach (var item in deserialized.features)
            {

                pipes.Add(new PipeClass(int.Parse(item.properties["MSLINK"].ToString()),
                                         item.properties["NODESTART"].ToString(),
                                         item.properties["NODEEND"].ToString(),
                                         double.Parse(item.properties["LENGTH"].ToString()),
                                         item.properties["DIAMNOMINA"].ToString()
                                         ));

                JArray o = JArray.Parse( item.geometry.coordinates.ToString());
               
                foreach ( var v in o)
                {
                    vertices.Add(new PktClass(int.Parse(item.properties["MSLINK"].ToString()),  double.Parse(v[0].ToString()), double.Parse(v[1].ToString())));
                }
                
            }

            //foreach (PipeClass item in pipes)
            //{
            //    item.print();
            //}

            //foreach (var item in vertices)
            //{
            //    item.print();
            //}
            
        }
    }

    public class PipeClass
    {
        public int ID;
        public string Node1;
        public string Node2;
        public double Lenght;
        public string Diameter;
        public int Roughness;
        public double MionorLoss;
        public string Status;

        public PipeClass(int _ID)
        {
            ID = _ID;
        }

        public PipeClass(int _ID, string _Node1, string _Node2, double _Lenght, string _Diameter)
        {
            ID = _ID;
            Node1 = _Node1;
            Node2 = _Node2;
            Lenght = _Lenght;
            Diameter = _Diameter;
            Roughness = 0;
            MionorLoss = 0;
            Status = "OPEN";
        }

        public void print()
        {
            Console.WriteLine( $"{ID}\t{Node1}\t{Node2}\t{Lenght}\t{Diameter}\t{Roughness}\t{MionorLoss}\t{Status}");
        }
    }

    public class PktClass
    {
        public PktClass(int [] array )
        {
            X_Coord = array[0];
            Y_Coord = array[1];
        }

        public PktClass(int node, double x, double y)
        {
            NODE = node;
            X_Coord = x;
            Y_Coord = y;
        }

        public void print()
        {
            Console.WriteLine( $"{NODE}\t{X_Coord}\t{Y_Coord}");
        }

        public int NODE;
        public double X_Coord;
        public double Y_Coord;
    }    
}
