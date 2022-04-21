// See https://aka.ms/new-console-template for more information
using ListaAppuntamenti;
List<Appuntamento> Appuntamenti = new List<Appuntamento>();
Appuntamento nuovo;
Console.WriteLine("Quale operazione vuoi fare?");
Console.WriteLine(" 1 Vuoi inserire un nuovo appuntamento all'agenda?");
Console.WriteLine(" 2 Vuoi Modificare un appuntamento vecchio?");
Console.WriteLine(" 3 Vuoi eliminare tutti gli appuntamenti?");
string risposta=Console.ReadLine();
switch (risposta)
{
    case "1":
        Console.WriteLine("Vuoi inserire un nuovo appuntamento all'agenda?Si/No");
        while (Console.ReadLine() == "Si")
        {
            Console.WriteLine("Inserire il nome dell'appuntamento");
            string Nuovo_nome = Console.ReadLine();

            Console.WriteLine("Inserire il luogo dell'appuntamento");
            string Nuovo_luogo = Console.ReadLine();

            try
            {
                Console.WriteLine("Inserire la data dell'appuntamento");
                DateTime Nuova_data = DateTime.Parse(Console.ReadLine());

                nuovo = new Appuntamento(Nuova_data, Nuovo_nome, Nuovo_luogo);

          Appuntamenti.Add(nuovo);

                nuovo.StampaTutto(Appuntamenti);


            }
            catch (Exception ex)                           
            {
                Console.WriteLine("La data è sbagliata perchè è troppo vecchia");                                              
            }

            Console.WriteLine("Vuoi inserire un altro appuntamento?");

        }
            if (Console.ReadLine() == "No")
            {
                Console.WriteLine("Questa è la tua lista appuntamenti fino a ora.");
                Console.WriteLine(Appuntamenti);
            }    
            

            break;
       


      case "2":

            Console.WriteLine("Vuoi Modificare un appuntamento vecchio?Si/No");
            if (Console.ReadLine() == "Si")
            {
                Console.WriteLine("Inserire il nome dell'appuntamento da modificare");
                string Vecchionome = Console.ReadLine();
                if (Vecchionome == nuovo.Getnome())
                {
                    Console.WriteLine("Inserire nuova data");
                    DateTime datacambiata = DateTime.Parse(Console.ReadLine());
                    nuovo.Cambiadata(datacambiata);
                }
                else
                {
                    Console.WriteLine("Questo appuntamento non esiste"); 
                }
            } else
            {
                Console.WriteLine("I tuoi appuntamenti sono" + Appuntamenti);
            }
            break;
    

    case "3":
        Console.WriteLine("Vuoi eliminare tutti gli appuntamenti? Si/No");
        if (Console.ReadLine() == "Si")
        {
            Appuntamenti.Clear();
        }
        else if (Appuntamenti == null)
        {
            Console.WriteLine("Non ci sono appuntamenti");
        }
        else
        {
            Console.WriteLine("Questa è la tua lista appuntamenti fino a ora.");
            Console.WriteLine(Appuntamenti);

        }
        
        break;
}

Console.WriteLine("Vuoi fare un  altra operazione?Si/No");
if(Console.ReadLine() == "No")
{
    Console.WriteLine("Arrivederci");
}
while(Console.ReadLine() =="Si")
{
    Console.WriteLine("Quale operazione vuoi fare?");
    risposta = Console.ReadLine();
    Console.WriteLine("Vuoi fare un altra operazione? ");
}




/*
try
{
     Console.WriteLine("Inserire la data dell'appuntamento");
        DateTime Nuova_data =DateTime.Parse( Console.ReadLine());

   }
catch (Exception e)
{
    Console.WriteLine("La data deve essere del formato DD/MM/AA");
}*/
