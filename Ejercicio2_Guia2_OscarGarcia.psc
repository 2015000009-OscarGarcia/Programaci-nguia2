Algoritmo sin_título
	Definir num1, num2 Como Real
	Definir msj Como Caracter
	Escribir Sin Saltar "Digite dos valores numericos: "
	leer num1
	leer num2
	
	
	Escribir "*************"
	Escribir "MENU PRINCIPAL"
	Escribir "1- suma"
	Escribir "2- resta"
	Escribir "3- multiplicación"
	Escribir "4- divisón"
	Escribir "5- salir"
	Escribir Sin Saltar "Digite el numero segun su operación: "
	leer opc
	
	Segun opc Hacer
		1:
			msj="El resultado de la suma es: "
			result=num1+num2
		2:
			msj="El resultado de la resta es: "
			result=num1-num2
		3:
			msj="El resultado de la multiplicaión es: "
			result=num1*num2
		4:
			msj="El resultado de la división es: "
			result=num1/num2
		5:
			msj="Saliendo del sistema..."
		De Otro Modo:
			msj="Seleccione una opción válida!!!"
	Fin Segun
	
	Escribir msj
	Escribir result
FinAlgoritmo
