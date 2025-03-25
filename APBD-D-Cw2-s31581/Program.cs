// See https://aka.ms/new-console-template for more information
using APBD_D_Cw2_s31581;

var banan = new Banan(27);
var jablko = new Jablko(19);
var coolingContainer = new CoolingContainer(38);
var gasContainer = new GasContainer();
Console.WriteLine(gasContainer.serialnumber);
//gasContainer.load(300);
coolingContainer.load(20,jablko);