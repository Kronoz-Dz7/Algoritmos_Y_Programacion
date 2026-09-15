Algoritmo ValidarAprobación
	Definir nota Como Real;
	Escribir "Ingrese la calificación final obtenida (0.0 - 5.0):";
	Leer nota;
	
	Si nota >= 3.0 Entonces
		
		Escribir "¡Enhorabuena! Ha aprobado satisfactoriamente la asignatura.";
	FinSi
	si nota < 3.0 Entonces
		Escribir "Lo setimos. Ha reprobado la asignatura.";
		
	FinSi
	Escribir "Proceso de reporte de calificaciones finalizado.";
FinAlgoritmo
