using System;

namespace Actividad3U2
{
	class MainClass
	{
		static int yellowCounter = 0;
		static int pinkCounter = 0;
		static int redCounter = 0;
		static int greenCounter = 0;
		static int blueCounter = 0;

		public static void Main (string[] args)
		{
			bool isInOperativeMode = true;

			Console.WriteLine ("\t\t\t====== SISTEMA CALCOMANIAS ======");
			Console.WriteLine ("* para terminar el conteo presione cualquier otra tecla\n\n\n");
			do {
				isInOperativeMode = requestForANewCart ();
			} while(isInOperativeMode);
			Console.WriteLine (@"
			-- Conteo Finalizado -- 
		Total de automoviles calcomania amarilla: {0}
		Total de automoviles calcomania rosa: {1}
		Total de automoviles calcomania roja: {2}
		Total de automoviles calcomania verde: {3}
		Total de automoviles calcomania azul: {4}
                ", yellowCounter, pinkCounter, redCounter, greenCounter, blueCounter);
		}

		static bool requestForANewCart ()
		{
			byte lastNumber;
			string plateColor;

			Console.WriteLine ("Nuevo auto, ingrese ultimo digito de la placa:");
			try {
			lastNumber = Byte.Parse (Console.ReadLine ());
			} catch(Exception e) {
				return false;
			}
			switch (lastNumber) {
			case 1:
			case 2:
				yellowCounter++;
				plateColor = "amarilla";
				break;
			case 3:
			case 4:
				pinkCounter++;
				plateColor = "rosa";
				break;
			case 5:
			case 6:
				redCounter++;
				plateColor = "roja";
				break;
			case 7:
			case 8:
				greenCounter++;
				plateColor = "verde";
				break;
			case 9:
			case 0:
				blueCounter++;
				plateColor = "azul";
				break;
			default:
				return false;
			}

			Console.WriteLine ("Auto ingresado con terminaciön {0}: Calcomania {1} \n", lastNumber, plateColor);
			return true;
		}
	}
}
