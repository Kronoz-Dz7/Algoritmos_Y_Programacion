Algoritmo PagoFacturaAgua
	Definir MontoOriginal, recargo, MontoTotal como real;
	Definir díasRetraso Como Entero;
	
	Escribir "Ingrese el monto original de la factura ($ - COD):";
	Leer MontoOriginal;
	
	Escribir "Ingrese los días de retraso en el pago: ";
	Leer díasRetraso;
	
	MontoTotal <-- MontoOriginal;
	
	si díasRetraso > 5 Entonces
		recargo <-- MontoOriginal * 0.05;
		MontoTotal <-- MontoOriginal + recargo;
		Escribir "Se ha aplicado un recargo del 5% ($" ,recargo, ") por mora.";
	FinSi
	Escribir "Monto total definitivo a pagar: $", MontoTotal;
FinAlgoritmo
