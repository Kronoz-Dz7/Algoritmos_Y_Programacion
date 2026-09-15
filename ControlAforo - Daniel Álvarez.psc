Algoritmo ControlAforo
	Definir asistentes, exceso Como Entero;
	Escribir "Ingrese la cantidad de asistentes confirmadoss";
	Leer asistentes;
	
	Si asistentes > 150 Entonces
		exceso = asistentes - 150;
		Escribir "¡ALERTA DE SEGURIDAD! Se ha excedidola capacida maxima de asistentes.";
		Escribir "Hay ", exceso, " Persona(s) por encima del limite permitido.";
	FinSi
	Escribir "Registro de aforo concluido";
FinAlgoritmo
