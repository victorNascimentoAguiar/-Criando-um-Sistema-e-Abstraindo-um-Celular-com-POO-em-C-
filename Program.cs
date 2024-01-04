using Abistraindo_um_POO_de_um_celular.models;

Console.WriteLine("nokia");
Smartphone nokia = new Nokia(numero:"1234", modelo: "j1e", imei : "4321",memoria : 10);
nokia.Ligar();
nokia.InstalarAplicativo("alarm");


Console.WriteLine("/n");

Console.WriteLine("iphone");
Smartphone iphone = new Iphone(numero:"1234", modelo: "15", imei : "5432",memoria : 300);
iphone.Ligar();
iphone.InstalarAplicativo("calculadora");