using System;

					
public class Program
{
	
	public static void Main()
	{
		//Definições do array
		int tamanho;
		int maior = 0;			
		int tamPar= 0;
        int tamImpar= 0;
		int soma = 0;
		
		Console.WriteLine("Informe o tamanho do array:");
		tamanho = Convert.ToInt32(Console.ReadLine());
			
		//Declarando o array
		int[] array = new int [tamanho];
		int[] par = new int [tamanho];
		int[] impar = new int [tamanho];
		
		//Definindo o valor máximo
		Console.WriteLine("Informe o valor máximo a ser sorteado");
		int maximo = Convert.ToInt32(Console.ReadLine());
		
		Random random = new Random();
		
		//Populando o array
		Console.WriteLine("\n");
		Console.WriteLine("Populando o array...");
		for (int i = 0; i < array.Length; i++){
			array[i] = random.Next(maximo);
		}
		
		
		Console.WriteLine("\n");
		Console.WriteLine("Exibindo o array:");
		for (int i = 0; i < array.Length; i++){
			Console.WriteLine(array[i]);	
		}
		
		
		Console.WriteLine("\n");
		Console.WriteLine("2- Exibindo o array: de tras para frente");
		for (int i = array.Length -1; i >= 0; i--){
			Console.WriteLine(array[i]);	
			soma += array[i]; //somando o array
		}
		
		//exibindo a soma
		Console.WriteLine("\n");
		Console.WriteLine("3- soma do array:");
		Console.WriteLine(soma);
		
				
		Console.WriteLine("\n");
		Console.WriteLine("4- Separando em par e impar");
		for (int i = 0; i < array.Length; i++){
			
			if (array[i] % 2 == 0)
				{
					par[tamPar] = array[i];	
					tamPar++;				
				} 
			else
				{
					impar[tamImpar] = array[i];
					tamImpar++;
				} 			
		}		
		
		Console.WriteLine("par: ");		
		for (int i = 0; i < tamPar; i++){
			Console.WriteLine(par[i]);
		}
		
		Console.WriteLine("Impar: ");		
		for (int i = 0; i < tamImpar; i++){
			Console.WriteLine(impar[i]);
		}			
		
		int menor = array[0];	
		
		Console.WriteLine("\n");
		Console.WriteLine("5- Menor, maior e media: ");
		for (int i = 0; i < array.Length; i++){
			if(array[i] > maior){
				maior = array[i];
			}
			
			if(array[i] < menor){
				menor = array[i];
			}
		}
		      
		
		Console.WriteLine("Menor: ");
		Console.WriteLine(menor);
		
		Console.WriteLine("Maior: ");
		Console.WriteLine(maior);
		
		Console.WriteLine("Media:");
		Console.WriteLine(soma / tamanho);
		
	}
}
