Console.WriteLine("Ingrese su nombre completo:");
string nombre = (Console.ReadLine());

Console.WriteLine("Ingrese su edad:");
uint edad = uint.Parse(Console.ReadLine());

double entrada, descuento1, descuento2, descuento3, total1, total2, total3;

entrada = 15000;
descuento1 = (15000*1);
descuento2 = (15000*0.05);
descuento3 = (15000*0.03);
total1 = (entrada - descuento1);
total2 = (entrada - descuento2);
total3 = (entrada - descuento3);


if(edad<4){
    Console.WriteLine("Usted " + nombre + " con la edad de " + edad + " años. El precio de la entrada es de: " + entrada + " usted obtuvo un total de descuento de: " + descuento1 + " el valor total a pagar es de: " + total1);
}
else if(edad>= 4 && edad<=18){
    Console.WriteLine("Usted " + nombre + " con la edad de " + edad + " años. El precio de su entrada es de: " + entrada + " usted obtuvo un total de descuento de: " + descuento2 + " el valor total a pagar es de: " + total2);
}
else{
    Console.WriteLine("Usted " + nombre + " con la edad de " + edad + " años. El precio de su entrada es de: " + entrada + " usted obtuvo un total de descuento de: " + descuento3 + " el valor total a pagar es de: " + total3);
}