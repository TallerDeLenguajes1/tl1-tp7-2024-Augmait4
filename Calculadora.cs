namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double resultado = 0;

        public double Resultado { get => resultado; }
        
        public void Sumar(double dato){
            resultado += dato;
        }
        public void Restar(double Dato){
            resultado -= Dato;
        } 
        public void Multiplicar(double Dato){
            resultado *= Dato;
        } 
        public void dividir(double Dato){
            resultado /= Dato;
        } 
        public void limpiar(){
            resultado = 0;
        }

    }
}