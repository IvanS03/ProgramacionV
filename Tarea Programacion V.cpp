#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

double funcion1(double a){
	
	double resul = 3.14 * (a * a);
	return resul;
}

double funcion2(double a, double b){
	
	double resul = a * b;
	return resul;
}

double funcion3(double a, double b){
	
	double resul = (a * b)/2;
	return resul;
}

int main(){
	
	float pi = M_PI;
	
	while (true)
	{	
		int a = 0;
		int resultado;
		
		while (a < 51){
		cout << "*";
		a++;}
		
		cout << "PROGRAMA PARA GEOMETRIA";
		
		int b = 0;
		while (b < 51){
		cout << "*";
		b++;}
		
		string opcion;
		
		cout << "\n¿Que area desea Calcular? \n(c) Circulo \n(r) Rectangulo \n(t) triangulo \n(s) Salir";
		cin >> opcion;
		
		string c;
		
		
		if (opcion == "s"){
			break;
		}
		
		if (opcion == "c"){
			
			double vradio;
			cout << "Ingrese Radio";
			cin >> vradio;
			double resultado = funcion1(vradio);
			cout << "\nEl resultado es:" << resultado;
		}
		
		else if(opcion == "r"){
			
			double vbase;
			double valtura;
			
			cout << "Ingrese La Base";
			cin >> vbase;
			
			cout << "Ingrese La Altura";
			cin >> valtura;
			
			double resultado = funcion2(vbase, valtura);
			cout << "\nEl resultado es:" << resultado;
		}
		
		else{
			
			double vbase;
			double valtura;
			
			cout << "Ingrese La Base";
			cin >> vbase;
			
			cout << "Ingrese La Altura";
			cin >> valtura;
			
			double resultado = funcion3(vbase, valtura);
			cout << "\nEl resultado es:" << resultado;
		}
			
			

	}
	
	cout << "\nGracias por usar el programa de calculo geometrico\n";
	
	return 0;
}
