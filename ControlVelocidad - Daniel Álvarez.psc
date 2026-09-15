Algoritmo ControlVelocidad
	definir velocidad Como Real;
	
	Escribir "Ingrese la velocidad registrada del vehiculo (km/h):";
	leer velocidad
	
	si velocidad > 80 Entonces
		Escribir "¡ALERTA! Ha superado el limite de velocidade de 80 km/h.:";
		Escribir "Se ha generadfo una fotomulta automaticamente.:";
	FinSi
	
	Escribir "Evaluación de tránsito finalizada.;";
FinAlgoritmo
