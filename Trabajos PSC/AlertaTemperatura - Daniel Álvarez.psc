Algoritmo AlertaTemperatura
	Definir temp Como Real;
	
	Escribir "Ingrese la temperatura actual en grados Celcius (°C):";
	Leer temp;
	
	si temp < 0 Entonces
		Escribir "ADVERTENCIA: Temperatura bajo cero detectada.";
		Escribir "Riesgo de congelamiento en carreteras.", "Conduzca con precaución.";
	FinSi
	 Escribir "Registro meteorológico completado";
FinAlgoritmo
