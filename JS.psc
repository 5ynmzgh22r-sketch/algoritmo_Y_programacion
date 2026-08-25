Algoritmo AreaTriangulo 
	Definir base, altura, area Como Real
 	Escribir "Ingrese base:"; Leer base 
	Escribir "Ingrese altura:"; Leer altura 
	
	area <- (base * altura) / 2
	Escribir "Área = ", area 


	Definir numero1 Como Entero
	Escribir "Ingrese N: " ; Leer numero1 
	
	Si numero1 % 2 = 0 Entonces
		Escribir "N es par"
	Sino 
		Escribir "N es impar"
	FinSi
FinAlgoritmo
	