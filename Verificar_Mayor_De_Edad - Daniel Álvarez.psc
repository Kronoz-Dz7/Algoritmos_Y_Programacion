Algoritmo Verificar_Mayor_De_Edad
	Escribir "Ingrese el año actual:"   // 1.Entrada
	leer anioactual
	Escribir "Ingrese su año de nacimiento:"
	Leer anionacimiento
	edad<- anioactual - anionacimiento   // 2.Proceso
	Si edad >= 18 Entonces              // 3.Salida
		Escribir "Es mayor de edad. Edad:", edad
	SiNo
		Escribir "Es menor de edad. Edad:", edad
	FinSi
FinAlgoritmo
