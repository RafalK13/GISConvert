
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
    public string FIRSTDATE { get; set; }
    public string FIRSTNBR { get; set; }
    public string SSCITY { get; set; }
    public string CITYID { get; set; }
    public string TREET { get; set; }
    public string STREETID { get; set; }
    public string ARCHIVENBR { get; set; }
    public string PROTECTION { get; set; }
    public object PROTECTI_1 { get; set; }
    public string MEASURE { get; set; }
    public string MEASUREID { get; set; }
    public string CLASSID { get; set; }
    public string CLOSEDATE { get; set; }
    public object CONTRACT { get; set; }
    public string CONTRACTOR { get; set; }
    public string CONTRACTID { get; set; }
    public string DIAMEXTERN { get; set; }
    public string DIAMINTER { get; set; }
    public string DIAMNOMINA { get; set; }
    public string DIAMNOMIID { get; set; }
    public string ENVIRONMEN { get; set; }
    public string ENVIRONMID { get; set; }
    public string EXPLOENDDO { get; set; }
    public string FINALEDATE { get; set; }
    public string FINALENBR { get; set; }
    public string FUNCTION { get; set; }
    public string FUNCTIONID { get; set; }
    public string GEOSOURCE { get; set; }
    public string GEOSOURCEI { get; set; }
    public string GROUNDTYPE { get; set; }
    public string GROUNDTYID { get; set; }
    public string GROUNDWATE { get; set; }
    public string ID { get; set; }
    public string INSTALLATI { get; set; }
    public string INVENTORYN { get; set; }
    public string LASTUPDATE { get; set; }
    public object LASTUSER { get; set; }
    public string LASTUSERID { get; set; }
    public string LENGTH { get; set; }
    public string MATERIAL { get; set; }
    public string MATEID { get; set; }
    public string MATERIALTY { get; set; }
    public string MATERIALID { get; set; }
    public string NODEEND { get; set; }
    public string NODESTART { get; set; }
    public string OWNERSHIP { get; set; }
    public string OWNERSHIPI { get; set; }
    public string PRESSURECL { get; set; }
    public string PRESSUREID { get; set; }
    public string PRESSUREZO { get; set; }
    public string PRESSURID { get; set; }
    public string PTDATE { get; set; }
    public string PTNBR { get; set; }
    public string SETTLEMENT { get; set; }
    public string SETTLEMID { get; set; }
    public string STATUS { get; set; }
    public string STATUSID { get; set; }
    public string TECHREQFIL { get; set; }
    public string TECHREQNBR { get; set; }
    public string Database_L { get; set; }
}

public class Geometry
{
    public string type { get; set; }
    public float[][] coordinates { get; set; }
}
