using ProductorConsumidor.Modelo;
using ProductorConsumidor.SinSincronizacion;

IBuffer recursoCompartido = new BufferImpl(); 
Random generador = new Random(); 
Productor productor = new Productor(recursoCompartido, generador); 
Consumidor consumidor = new Consumidor(recursoCompartido, generador); 

Thread hiloProductor = new Thread(new ThreadStart(productor.Producir)); 
Thread hiloConsumidor = new Thread(new ThreadStart(consumidor.Consumir)); 
hiloProductor.Name = "Productor"; 
hiloConsumidor.Name = "Consumidor"; hiloProductor.Start(); 
hiloConsumidor.Start();
