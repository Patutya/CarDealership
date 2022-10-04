using Rehearse;

List<BMW> list = new List<BMW>();
List<MERC> list2 = new List<MERC>();
List<PORSCHE> list3 = new List<PORSCHE>();

if (1 == 1)
{
    MERC merc = new MERC();
    merc.Id = 3;
    merc.Value = 32233;
    merc.IsManual = true;
    merc.DoorCount = 3;
    merc.Model = "550C";
    merc.IsLux = false;
    list2.Add(merc);

    merc = new MERC();
    merc.Id = 4;
    merc.Value = 77777;
    merc.IsManual = false;
    merc.DoorCount = 5;
    merc.Model = "550S";
    merc.IsLux = true;
    list2.Add(merc);

    merc = new MERC();
    merc.Id = 5;
    merc.Value = 88883;
    merc.IsManual = true;
    merc.DoorCount = 3;
    merc.Model = "64C";
    merc.IsLux = false;
    list2.Add(merc);

    merc = new MERC();
    merc.Id = 6;
    merc.Value = 101010;
    merc.IsManual = false;
    merc.DoorCount = 5;
    merc.Model = "AMG";
    merc.IsLux = false;
    list2.Add(merc);
} //kodis sisuftavistvis miweria if ebi
if (1 == 1)
{
    BMW bmw = new BMW();
    bmw.HasVanos = true;
    bmw.IsManual = true;
    bmw.Value = 57000;
    bmw.Model = "3series";
    bmw.DoorCount = 5;
    bmw.Id = 1;
    list.Add(bmw);

    bmw = new BMW();
    bmw.HasVanos = false;
    bmw.IsManual = true;
    bmw.Value = 36000;
    bmw.Model = "1series";
    bmw.DoorCount = 3;
    bmw.Id = 2;
    list.Add(bmw);
}

CarFabricCompany company = new CarFabricCompany() { Address = "Beliashvilis qucha", FactoryName = "Fabrika", Bmws = new List<BMW>(list), Mercs = new List<MERC>(list2), Porsches = new List<PORSCHE>(list3), };
Console.WriteLine(company.FactoryName);
Console.WriteLine(company.Address);
for(int i = 0; i<company.Mercs.Count; i++)
{
    Console.WriteLine(company.Mercs[i].Model);
    Console.WriteLine(company.Mercs[i].Value);
    Console.WriteLine(company.Mercs[i].IsLux);
    Console.WriteLine(company.Mercs[i].DoorCount);
    Console.WriteLine(company.Mercs[i].IsManual);
    Console.WriteLine(company.Mercs[i].Id);

}












