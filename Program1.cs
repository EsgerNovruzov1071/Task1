string birMehsulAdi = "ad1";
string ikiMehsulAdi = "ad1";
string ucMehsulAdi = "ad1";

int birMehsulIlkinQIYMET = 100;
int ikiMehsullkinQIYMET = 200;
int ucMehsullkinQIYMET = 300;

int endirimFaizi = 10;

int yekunQiymetBir = birMehsulIlkinQIYMET / 100 * 100 - endirimFaizi;
Console.WriteLine(yekunQiymetBir);

