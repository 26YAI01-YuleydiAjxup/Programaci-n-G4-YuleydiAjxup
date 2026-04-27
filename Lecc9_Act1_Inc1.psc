Algoritmo Lecc9_Act1_Inc1
	Definir pesoAcumulado, pesoManzana, contarManzanas Como Real
	pesoAcumulado=0
	contarManzanas=0
	
	Escribir "=======Báscula del Mercado======="
	
	Mientras pesoAcumulado<1000 Hacer
		Escribir "Ingrese el peso de la manzana en gramos (100-300)"
		leer pesoManzana
		Si pesoManzana>=100 y pesoManzana<=300 Entonces
			pesoAcumulado=pesoAcumulado+pesoManzana
			contarManzanas=contarManzanas+1
			Escribir "Peso actual: ",pesoAcumulado, "gramos"
		SiNo
			Escribir "Error: Esa manzana no cumple con el peso solicitado"
		Fin Si
	FinMientras
	
	Escribir "Meta alcanzada! Ya tiene ",pesoAcumulado/1000, "kilos en la bolsa."
	Escribir "Usted acumulo ", contarManzanas, " el total de Manzanas"
	
FinAlgoritmo
