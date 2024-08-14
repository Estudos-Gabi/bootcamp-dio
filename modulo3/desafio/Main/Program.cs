using Classes.Models;

Nokia nokia = new Nokia(numero: "1234",modelo: "XS", imei: "algum", memoria: 123 );

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Zapzap");

Iphone iphone = new Iphone(numero: "13424",modelo: "XS", imei: "algum", memoria: 123 );

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Zapzap2");

