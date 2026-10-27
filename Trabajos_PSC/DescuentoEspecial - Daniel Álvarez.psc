Algoritmo DescuentoEspecial
	Definir montocompra, descuento, montofinal Como Real;
	Escribir "Ingrese el valor total de su compra ($):";
	leer montocompra;
	
	montofinal <- montocompra  //Por defecto no hay descuento
	
	si montocompra > 10000 Entonces
		descuento <- montocompra * 0.10;
		montofinal <- montocompra - descuento;
		Escribir "¡FELICIDADES! Ha recibido un descuento de: $", descuento;
	FinSi
	
	Escribir "El total a pagar es: $", montofinal;
FinAlgoritmo
