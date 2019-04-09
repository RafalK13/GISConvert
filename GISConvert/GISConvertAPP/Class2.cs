
public class Rootobject
{
    public string type { get; set; }
    public string name { get; set; }
    public Crs crs { get; set; }
    public Feature[] features { get; set; }
}

public class Crs
{
    public string type { get; set; }
    public Properties properties { get; set; }
}

public class Properties
{
    public string name { get; set; }
}

public class Feature
{
    public string type { get; set; }
    public Properties1 properties { get; set; }
    public Geometry geometry { get; set; }
}

public class Properties1
{
    public string MSLINK { get; set; }
    public string CLASS { get; set; }
    public string CLASSID { get; set; }
    public string DIAMETER { get; set; }
    public string DIAMETERID { get; set; }
    public string ID { get; set; }
    public string LASTUPDATE { get; set; }
    public string LASTUSERID { get; set; }
    public string LINECAVITY { get; set; }
    public string MATERIAL { get; set; }
    public string MATERIALID { get; set; }
    public string MATERIALTY { get; set; }
    public string MATERIALTI { get; set; }
    public object ORDINATEGL { get; set; }
    public string ORDINATEIN { get; set; }
    public string TYPE { get; set; }
    public string TYPEID { get; set; }
}

public class Geometry
{
    public string type { get; set; }
    public float[] coordinates { get; set; }
}

