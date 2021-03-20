    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    namespace Expresiones_Regulares
    {
        class Program
        {
            static void Main(string[] args)
            {
                try 
                {
                    int paracaso;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Formulario para la validacion de Datos utilizando expresiones Regulares");
                        Console.WriteLine("Dato a validar\n1. Nombre \n2. Apellidos \n3. CURP \n4. RFC\n5. Sexo \n6. Fecha de Nacimiento \n7. Calle \n8. Colonia\n9. Codigo Postal \n10. Numero de casa\n11. Salir del programa");
                        Console.Write("La opcion que desea Validar: ");
                        paracaso = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (paracaso)
                        {
                            case 1:
                                Console.WriteLine("Nombre que desea Validar: ");
                                string Nombre = string.Format(Console.ReadLine());
                                Regex Name = new Regex(@"^[a-zA-Z]{1,40}\s?[a-zA-Z]{1,40}$");
                                if (Name.IsMatch(Nombre))
                                {
                                    Console.WriteLine("El Nombre esta bien escrito");
                                }
                                else
                                {
                                    Console.WriteLine("El nombre esta mal escrito; No debe contener caracteres especiales o Digitos");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine("Apellidos que desea Validar: ");
                                string Apellidos = string.Format(Console.ReadLine());
                                Regex LastName = new Regex(@"^[a-zA-Z]{1,40}\s?[a-zA-Z]{1,40}$");
                                if (LastName.IsMatch(Apellidos))
                                {
                                    Console.WriteLine("Los apellidos estan bien escritos");
                                }
                                else
                                {
                                    Console.WriteLine("Los apellidos estan mal escritos; No debe contener caracteres especiales o Digitos");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.WriteLine("CURP que desea Validar: ");
                                string Curp = string.Format(Console.ReadLine());
                                Regex CURP = new Regex(@"^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9a-zA-Z]{1}[0-9]{1}$");//CAHO991127HBCRRS04
                                if (CURP.IsMatch(Curp))
                                {
                                    Console.WriteLine("El CURP esta bien escrito");
                                }
                                else
                                {
                                    Console.WriteLine("El CURP esta mal escrito; Se debe considerar todas las reglas antes de escribirlo");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.WriteLine("RFC que desea Validar: ");
                                string Rfc = string.Format(Console.ReadLine());
                                Regex RFC = new Regex(@"^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])([0-9]|[a-zA-Z]){3}$");
                                if (RFC.IsMatch(Rfc))
                                {
                                    Console.WriteLine("El RFC esta bien escrito");
                                }
                                else
                                {
                                    Console.WriteLine("El RFC esta mal escrito; Se debe considerar todas las reglas antes de escribirlo junto a la HomoClave");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.WriteLine("Genero que desea Validar: ");
                                string Genero = string.Format(Console.ReadLine());
                                Regex Gender = new Regex(@"^[HM]{1}$");
                                if (Gender.IsMatch(Genero))
                                {
                                    Console.WriteLine("El Genero esta bien escrito");
                                }
                                else
                                {
                                    Console.WriteLine("El Genero esta mal escroto; Se acepta un caracter H o M");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 6:
                                Console.WriteLine("Fecha de nacimiento que desea Validar: ");
                                string FechaNacimiento = string.Format(Console.ReadLine());
                                Regex BornDate = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])-?(0[1-9]|1[0-2])-?[0-9]{2}$");
                                if (BornDate.IsMatch(FechaNacimiento))
                                {
                                    Console.WriteLine("La fecha de Nacimiento esta bien escrita");
                                }
                                else
                                {
                                    Console.WriteLine("I don't think so; Siga el siguiente formato DD-MM-AA");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 7:
                                Console.WriteLine("Calle que desea Validar: ");
                                string Calle = string.Format(Console.ReadLine());
                                Regex Street = new Regex(@"^[a-zA-Z0-9]{1,40}\s?[a-zA-Z0-9]{1,40}\s?[a-zA-Z0-9]{1,40}\s?$");
                                if (Street.IsMatch(Calle))
                                {
                                    Console.WriteLine("La Calle esta bien escrita");
                                }
                                else
                                {
                                    Console.WriteLine("La calle esta mal escrita; Pruebe escribiendo otra vez");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 8:
                                Console.WriteLine("Colonia que desea Validar: ");
                                string Colonia = string.Format(Console.ReadLine());
                                Regex Colony = new Regex(@"^[a-zA-Z0-9]{1,40}\s?[a-zA-Z0-9]{1,40}\s?[a-zA-Z0-9]{1,40}\s?$");
                                if (Colony.IsMatch(Colonia))
                                {
                                    Console.WriteLine("La Colonia esta bien escrita");
                                }
                                else
                                {
                                    Console.WriteLine("La colonia esta mal escrita; Pruebe escribiendo otra vez");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 9:
                                Console.WriteLine("Codigo Postal que desea Validar: ");
                                string CodigoPostal = string.Format(Console.ReadLine());
                                Regex PostalCode = new Regex(@"^[0-9]{5}$");
                                if (PostalCode.IsMatch(CodigoPostal))
                                {
                                    Console.WriteLine("El Codigo Postal esta bien escrito");
                                }
                                else
                                {
                                    Console.WriteLine("Codigo Postal esta mal escrito");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 10:
                                Console.WriteLine("Telefono que desea Validar(Sin espacios): ");
                                string Telefono = string.Format(Console.ReadLine());
                                Regex Phone = new Regex(@"^\d{5,15}");
                                if (Phone.IsMatch(Telefono))
                                {
                                    Console.WriteLine("El telefono esta bien escrito");
                                }
                                else
                                {
                                    Console.WriteLine("El telefono esta mal escrito; No se aceptan caracteres especiales(Guiones, puntos, entre otros)");
                                }
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                            case 11:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Esa opcion no es valida");
                                Console.WriteLine("Presione cualquier tecla para regresar al menu");
                                Console.ReadKey();
                                break;
                        }
                    } while (paracaso != 4);
                }
                catch (Exception e) 
                {
                    Console.Clear();
                    Console.WriteLine("No se pueden usar letras o caracteres especiales\nSaliendo del programa\n", e);
                    Console.ReadKey();
                }
            }
        }
    }
