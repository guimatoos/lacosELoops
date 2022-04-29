    
    using System;

    namespace laçosELoops
{

    class Program
    
    {
      
        static void Main()
    
    {
    
    string[] names = {"Fredi" , "Mariana"};
        
    for (int i = 0; i < names.Length; i++) // contador iniciando no 0, vai até o tamanho do array (Length)
     
     { 
        Console.WriteLine(names[i]); //nome do array[i] + chaves e contador
     }

        //OU

     foreach (string name in names) // para cada nome na coleção name(s)
     
     {
        Console.WriteLine(name); // escreva esse nome
     }
    
        //Buscando um item do array(posição)

        Console.WriteLine(names[1]);
    
    }
}

}
