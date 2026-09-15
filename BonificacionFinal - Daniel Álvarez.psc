Algoritmo BonificacionFinal
	Definir unidadesVendidas, antiguedad Como Entero;
	Definir sueldoBase, bonificacion, sueldoFinal Como Real;
	
	sueldoBase <- 2200000
	bonificacion <- 200000
	sueldoFinal <- sueldoBase
	
	Escribir "Ingrese la cantidad de unidades vendidas en el mes: ";
	leer unidadesVendidas;
	Escribir "Ingrese los años de antiguedad en la empresa: ";
	Leer antiguedad;
	
	Si unidadesVendidas > 50 Y antiguedad > 2 Entonces
		sueldoFinal <- sueldoBase + bonificacion;
		Escribir "¡FELICIDADES! Ha cumplido con las metas de ventas, tiene una bonificacion final de: $", bonificacion ;
		
	FinSi
	Escribir "Tu salario este mes es de: $", sueldoFinal;
FinAlgoritmo
