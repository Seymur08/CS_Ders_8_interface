using CS_Ders_8_interface;
using CS_Ders_8_interface.Bank_namspace;

CEO ceo = new CEO("Seymur","Quliyev",34,"Employee",750);

Worker worker = new Worker("Eli", "Eliyev", 24, "Worker", 600,"09:30","17:00");

Manager manager = new Manager("Hesen", "Hesenov", 26, "Manager", 800);

Client client = new Client("Veli", "Veliyev", 26,"merdekan","merdekan",1200);


ceo.Show();
worker.Show();
manager.Show();
client.Show();











