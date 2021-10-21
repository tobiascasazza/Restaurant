using System;
using System.Data;
namespace Restaurant
{
    class Resto
    {
        public static bool[] Mesas;
        public static String[,] Platos;
        public static int[,] Ventas;
        /******************************************************/
        /****                MENUES                        ****/
        /******************************************************/
        /*PROGRAMA*/
        /// <summary>
        /// Maneja la Logica central del programa
        /// </summary>
        static void Programa()
        {
            Resto.Mesas = new bool[15] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            Resto.Platos = CargarPlatos();
            Resto.Ventas = CargarVentas();

            //DECLARO VARIABLES PARA ALMACENAR LOS DATOS DEL PROGRAMA
            string opcionElegida = "0";

            //EMPIEZO EL BUCLE INFINITO DEL MENU PRINICPAL HASTA QUE SE TECLEE 6
            while (opcionElegida != "8")
            {
                Console.Clear();
                ImprimirMenu();
                Console.Write("\n\nOPCION: ");

                opcionElegida = Console.ReadLine();

                if (opcionElegida == "1" || opcionElegida == "2" || opcionElegida == "3" || opcionElegida == "4" || opcionElegida == "8")
                {
                    switch (opcionElegida)
                    {
                        //CASO 1: INGRESAR AL SUBMENU PLATOS
                        case "1":
                            SubMenuPlatos();
                            break;
                        //CASO 2: INGRESAR AL SUBMENU VENTAS
                        case "2":
                            SubMenuVentas();
                            break;
                        //OPCION 3: INGRESAR AL SUBMENU LISTADOS
                        case "3":
                            SubMenuListados();
                            break;
                        //OPCION 4: INGRESAR AL SUBMENU REPORTES
                        case "4":
                            SubMenuReportes();
                            break;
                        //OPCION 6: SALIR DE LA APP
                        case "8":
                            ImprimirFinalPrograma();
                            break;
                    }
                }
                //SI SE TIPEA OTRA COSA QUE NO SEAN LOS 5 NUMEROS DA ERROR Y VUELVE A INTENTAR
                else
                {
                    Console.Clear();
                    ImprimirMenu();
                    Console.Write("\nSe tipeó una opcion incorrecta. ENTER para volver a intentar");
                    Console.ReadKey();
                }
            }
        }

        /*<FUNCIONAMIENTO SUBMENUES>*/
        /// <summary>
        /// Maneja la Logica central del SubMenu Platos
        /// </summary>
        static void SubMenuPlatos()
        {
            string opcionelegida = "0";

            while (opcionelegida != "8")
            {
                ImprimirSubMenuPlatos();
                Console.Write("\n\nOpcion: ");

                opcionelegida = Console.ReadLine();

                if (opcionelegida == "1" || opcionelegida == "2" || opcionelegida == "3" || opcionelegida == "4" || opcionelegida == "8")
                {
                    switch (opcionelegida)
                    {
                        //CASO 1: ALTA PLATO NUEVO
                        case "1":
                            AltaPlato();
                            break;
                        //CASO 2: BAJA PLATO
                        case "2":
                            BajaPlato();
                            break;
                        //CASO 3: CONSULTAR PLATO
                        case "3":
                            ConsultarPlato();
                            break;
                        //CASO 3: EDITAR PLATO
                        case "4":
                            EditarPlato();
                            break;
                        //OPCION 8: ATRAS
                        case "8":
                            break;
                    }
                }
                //si se tipea otra cosa que no sean los 5 numeros da error y vuelve a intentar
                else
                {
                    Console.Clear();
                    ImprimirSubMenuPlatos();
                    Console.Write("\nse tipeó una opcion incorrecta. enter para volver a intentar");
                    Console.ReadKey();
                }
            }

        }

        /// <summary>
        /// Maneja la Logica central del SubMenu Ventas
        /// </summary>
        static void SubMenuVentas()
        {
            string opcionelegida = "0";

            while (opcionelegida != "8")
            {
                ImprimirSubMenuVentas();
                Console.Write("\n\nOpcion: ");

                opcionelegida = Console.ReadLine();

                if (opcionelegida == "1" || opcionelegida == "2" || opcionelegida == "3" || opcionelegida == "4" || opcionelegida == "5" || opcionelegida == "6" || opcionelegida == "8")
                {
                    switch (opcionelegida)
                    {
                        //CASO 1: HACER VENTA
                        case "1":
                            HacerVenta();
                            break;
                        //CASO 2: ELIMINAR VENTA
                        case "2":
                            EliminarVenta();
                            break;
                        //OPCION 3: CONSULTAR VENTAS
                        case "3":
                            ConsultarVentas();
                            break;
                        //OPCION 4: ABRIR MESA
                        case "4":
                            LlenarMesa();
                            break;
                        //OPCION 5: CERRAR MESA
                        case "5":
                            VaciarMesa();
                            break;
                        //OPCION 6: MOSTRAR SALON
                        case "6":
                            ImprimirDibujoSalon(Resto.Mesas);
                            break;
                        //OPCION 8: ATRAS
                        case "8":
                            break;
                    }
                }
                //si se tipea otra cosa que no sean los 5 numeros da error y vuelve a intentar
                else
                {
                    Console.Clear();
                    ImprimirSubMenuVentas();
                    Console.Write("\nse tipeó una opcion incorrecta. enter para volver a intentar");
                    Console.ReadKey();
                }
            }

        }

        /// <summary>
        /// Maneja la Logica central del SubMenu Listados
        /// </summary>
        static void SubMenuListados()
        {
            string opcionelegida = "0";

            while (opcionelegida != "8")
            {
                ImprimirSubMenuListados();
                Console.Write("\n\nOpcion: ");

                opcionelegida = Console.ReadLine();

                if (opcionelegida == "1" || opcionelegida == "2" || opcionelegida == "3" || opcionelegida == "4" || opcionelegida == "8")
                {
                    switch (opcionelegida)
                    {
                        //CASO 1: MOSTRAR PLATOS
                        case "1":
                            ImprimirMostrarPlatos();
                            break;
                        //CASO 2: PLATOS ORDENADOS POR CATEGORIA
                        case "2":
                            ImprimirPlatosOP("Categoria");
                            break;
                        //OPCION 3: PLATOS ORDENADOS POR ORDEN DE PRECIO
                        case "3":
                            ImprimirPlatosOP("Precio");
                            break;
                        //OPCION 4: VENTAS FACTURADAS CON MESA CERRADA
                        case "4":
                            ImprimirMostrarVentas();
                            break;

                        //OPCION 8: SALIR
                        case "8":
                            break;

                    }
                }
                //si se tipea otra cosa que no sean los 5 numeros da error y vuelve a intentar
                else
                {
                    Console.Clear();
                    ImprimirSubMenuListados();
                    Console.Write("\nse tipeó una opcion incorrecta. enter para volver a intentar");
                    Console.ReadKey();
                }
            }

        }

        /// <summary>
        /// Maneja la Logica central del SubMenu Reportes
        /// </summary>
        static void SubMenuReportes()
        {
            string opcionelegida = "0";

            while (opcionelegida != "8")
            {
                ImprimirSubMenuReportes();
                Console.Write("\n\nOpcion: ");

                opcionelegida = Console.ReadLine();

                if (opcionelegida == "1" || opcionelegida == "2" || opcionelegida == "3" || opcionelegida == "4" ||
                    opcionelegida == "5" || opcionelegida == "8")
                {
                    switch (opcionelegida)
                    {
                        //CASO 1: LISTADO REPORTE DE COSTO BENEFICIO
                        case "1":
                            ImprimirMostrarCostoBeneficioPlatos();
                            break;
                        //CASO 2: 
                        case "2":
                            ImprimirMostrarPlatosMasVendidos();
                            break;
                        //OPCION 3: 
                        case "3":
                            ImprimirMostrarCategoriasMasVendidas();
                            break;
                        //OPCION 4: 
                        case "4":
                            ImprimirMostrarCostoBeneficioVenta();
                            break;
                        //OPCION 5: 
                        case "5":

                            break;
                        //OPCION 8: 
                        case "8":
                            break;

                    }
                }
                //si se tipea otra cosa que no sean los 5 numeros da error y vuelve a intentar
                else
                {
                    Console.Clear();
                    ImprimirSubMenuReportes();
                    Console.Write("\nse tipeó una opcion incorrecta. enter para volver a intentar");
                    Console.ReadKey();
                }
            }

        }
        /*<FUNCIONAMIENTO SUBMENUES/>*/

        /******************************************************/
        /****                LOGICA                        ****/
        /******************************************************/


        /*<FUNCIONAMIENTO PANTALLAS>*/
        /// <summary>
        /// Funcionamiento Principal del ALta de Platos
        /// </summary>
        static void AltaPlato()
        {
            string[] platoCompleto = new string[5];
            bool prueba = true;

            platoCompleto[0] = ConseguirSecuencialVacio(Resto.Platos);
            if (platoCompleto[0] == "-1")
            {
                platoCompleto[0] = "ERROR";
                ImprimirAltaPlatos(platoCompleto[0]);
                WriteLineRed("\nNO HAY ESPACIO EN MEMORIA. DAR DE BAJA UN PLATO Y VOLVER A INTENTAR (Max. 20)");
                Console.ReadKey();
                return;
            }

            ImprimirAltaPlatos(platoCompleto[0]);
            Console.Write("\nNOMBRE: ");
            platoCompleto[1] = Console.ReadLine();
            prueba = int.TryParse(platoCompleto[1], out int platoCompletoint);
            if (prueba == true || platoCompleto[1].Trim() == "")
            {
                ImprimirAltaPlatos(platoCompleto[0]);
                WriteLineRed("\nERROR AL CARGAR EL NOMBRE");
                Console.ReadKey();
                return;
            }


            ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1]);

            Console.Write("\nCATEGORIA: ");
            platoCompleto[2] = Console.ReadLine();
            prueba = int.TryParse(platoCompleto[2], out platoCompletoint);
            if (prueba == true || platoCompleto[2].Trim() == "")
            {
                ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1]);
                WriteLineRed("\nERROR AL CARGAR CATEGORIA");
                Console.ReadKey();
                return;
            }

            ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2]);

            Console.Write("\nCOSTO: ");
            platoCompleto[3] = Console.ReadLine();

            prueba = int.TryParse(platoCompleto[3], out platoCompletoint);
            if (prueba == false || platoCompleto[3].Trim() == "")
            {
                ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2]);
                WriteLineRed("\nERROR AL CARGAR EL COSTO");
                Console.ReadKey();
                return;
            }

            ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2], platoCompleto[3]);

            Console.Write("\nPRECIO: ");
            platoCompleto[4] = Console.ReadLine();
            prueba = int.TryParse(platoCompleto[4], out platoCompletoint);
            if (prueba == false || platoCompleto[4].Trim() == "")
            {
                ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2], platoCompleto[3]);
                WriteLineRed("\nERROR AL CARGAR EL PRECIO");
                Console.ReadKey();
                return;
            }
            ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2], platoCompleto[3], platoCompleto[4]);

            CargarAlta(platoCompleto);
            WriteLineGreen("\nPLATO CARGADO CON EXITO");
            Console.ReadKey();

        }

        /// <summary>
        /// Funcionamiento Principal de la Baja de Platos
        /// </summary>
        static void BajaPlato()
        {
            string codigoBaja;
            string[] filaConseguida;
            string eleccion = "";

            ImprimirBajaPlatos();
            Console.Write("\nCODIGO A DAR DE BAJA: ");
            codigoBaja = Console.ReadLine();

            filaConseguida = ConseguirFilaPlatos(Resto.Platos, codigoBaja);
            if (filaConseguida[0] == "-1")
            {
                WriteLineRed("\nNUMERO INGRESADO NO ENCONTRADO");
                Console.ReadKey();
                return;
            }
            ImprimirBajaPlatos(filaConseguida[0], filaConseguida[1], filaConseguida[2], filaConseguida[3], filaConseguida[4]);
            Console.Write("\nSEGURO QUE QUIERE ELIMINAR? S/N\n\n");

            while (eleccion.ToUpper() != "S" || eleccion.ToUpper() != "N")
            {
                eleccion = Console.ReadLine();
                if (eleccion.ToUpper() == "S")
                {
                    CargarBaja(filaConseguida);
                    ImprimirBajaPlatos(filaConseguida[0], filaConseguida[1], filaConseguida[2], filaConseguida[3], filaConseguida[4]);
                    WriteLineGreen("\n\nPLATO DADO DE BAJA EN EL SISTEMA");
                    Console.ReadKey();
                    break;
                }
                else if (eleccion.ToUpper() == "N")
                {
                    ImprimirBajaPlatos(filaConseguida[0], filaConseguida[1], filaConseguida[2], filaConseguida[3], filaConseguida[4]);
                    WriteLineRed("\n\nNO SE DIO DE BAJA EL PLATO EN EL SISTEMA");
                    Console.ReadKey();
                    break;
                }
                ImprimirBajaPlatos(filaConseguida[0], filaConseguida[1], filaConseguida[2], filaConseguida[3], filaConseguida[4]);
                Console.Write("\nCARACTER INVALIDO, INTENTE DE NUEVO (S/N)\n\n");
            }


        }

        /// <summary>
        /// Funcionamiento Principal de la Consulta de Platos
        /// </summary>
        static void ConsultarPlato()
        {
            string codigoBaja;
            string[] filaConseguida;

            ImprimirConsultaPlatos();
            Console.Write("\nCODIGO A CONSULTAR: ");
            codigoBaja = Console.ReadLine();

            filaConseguida = ConseguirFilaPlatos(Resto.Platos, codigoBaja);
            if (filaConseguida[0] == "-1")
            {
                WriteLineRed("\nNUMERO INGRESADO NO ENCONTRADO");
                Console.ReadKey();
                return;
            }
            ImprimirConsultaPlatos(filaConseguida[0], filaConseguida[1], filaConseguida[2], filaConseguida[3], filaConseguida[4]);
            Console.ReadKey();
        }
        /// <summary>
        /// Funcionamiento Principal de la Edicion de Plato
        /// </summary>
        static void EditarPlato()
        {
            string codigoBaja;
            string[] filaConseguida;
            string eleccion = "";

            ImprimirBajaPlatos();
            Console.Write("\nCODIGO DE PLATO A EDITAR: ");
            codigoBaja = Console.ReadLine();

            filaConseguida = ConseguirFilaPlatos(Resto.Platos, codigoBaja);
            if (filaConseguida[0] == "-1")
            {
                WriteLineRed("\nNUMERO INGRESADO NO ENCONTRADO");
                Console.ReadKey();
                return;
            }
            ImprimirBajaPlatos(filaConseguida[0], filaConseguida[1], filaConseguida[2], filaConseguida[3], filaConseguida[4]);
            Console.Write("\nSEGURO QUE QUIERE EDITARLO? S/N\n\n");

            while (eleccion != "S" || eleccion != "N")
            {
                eleccion = Console.ReadLine();
                if (eleccion == "S")
                {
                    CargarBaja(filaConseguida);
                    ImprimirBajaPlatos(filaConseguida[0], filaConseguida[1], filaConseguida[2], filaConseguida[3], filaConseguida[4]);
                    string[] platoCompleto = new string[5];
                    bool prueba = true;

                    platoCompleto[0] = filaConseguida[0];

                    ImprimirAltaPlatos(platoCompleto[0]);

                    while (prueba == true)
                    {
                        Console.Write("\nNOMBRE: ");
                        platoCompleto[1] = Console.ReadLine();
                        prueba = int.TryParse(platoCompleto[1], out int platoCompletoInt);
                        if (prueba == true || platoCompleto[1].Trim() == "")
                        {
                            ImprimirAltaPlatos(platoCompleto[0]);
                            Console.WriteLine("\nERROR AL CARGAR EL NOMBRE, INTENTE DE NUEVO");
                            Console.ReadKey();
                        }
                    }

                    ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1]);
                    prueba = true;
                    while (prueba == true)
                    {
                        Console.Write("\nCATEGORIA: ");
                        platoCompleto[2] = Console.ReadLine();
                        prueba = int.TryParse(platoCompleto[2], out int platoCompletoint);
                        if (prueba == true || platoCompleto[2].Trim() == "")
                        {
                            ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1]);
                            WriteLineRed("\nERROR AL CARGAR CATEGORIA, VUELVE A INTENTARR");
                            Console.ReadKey();

                        }
                    }

                    ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2]);
                    prueba = false;
                    while (prueba == false)
                    {
                        Console.Write("\nCOSTO: ");
                        platoCompleto[3] = Console.ReadLine();

                        prueba = int.TryParse(platoCompleto[3], out int platoCompletoInt);
                        if (prueba == false || platoCompleto[3].Trim() == "")
                        {
                            ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2]);
                            WriteLineRed("\nERROR AL CARGAR EL COSTO, VOLVER A INTENTAR.");
                            Console.ReadKey();

                        }
                    }


                    ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2], platoCompleto[3]);
                    prueba = false;
                    while (prueba == false)
                    {
                        Console.Write("\nPRECIO: ");
                        platoCompleto[4] = Console.ReadLine();
                        prueba = int.TryParse(platoCompleto[4], out int platoCompletoInt);
                        if (prueba == false || platoCompleto[4].Trim() == "")
                        {
                            ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2], platoCompleto[3]);
                            WriteLineRed("\nERROR AL CARGAR EL PRECIO, VUELVA A INTENTAR");
                            Console.ReadKey();

                        }
                    }

                    ImprimirAltaPlatos(platoCompleto[0], platoCompleto[1], platoCompleto[2], platoCompleto[3], platoCompleto[4]);

                    CargarAlta(platoCompleto);
                    WriteLineGreen("\nPLATO EDITADO CON EXITO");
                    Console.ReadKey();
                    break;
                }
                else if (eleccion == "N")
                {
                    ImprimirBajaPlatos(filaConseguida[0], filaConseguida[1], filaConseguida[2], filaConseguida[3], filaConseguida[4]);
                    WriteLineRed("\n\nSALIR SIN EDITAR");
                    Console.ReadKey();
                    break;
                }
                ImprimirBajaPlatos(filaConseguida[0], filaConseguida[1], filaConseguida[2], filaConseguida[3], filaConseguida[4]);
                Console.Write("\nCARACTER INVALIDO, INTENTE DE NUEVO (S/N)\n\n");
            }
        }
        /// <summary>
        /// Funcionamiento Principal de Llenar Mesa
        /// </summary>
        static void LlenarMesa()
        {
            string mesa = "";
            int mesaInt = 100;
            bool prueba = false;

            ImprimirLlenarMesa();
            Console.Write("\n\nMESA: ");

            mesa = Console.ReadLine();
            prueba = int.TryParse(mesa, out mesaInt);
            if (mesaInt > 15 || prueba == false)
            {
                ImprimirLlenarMesa();
                WriteLineRed("\nMESA NO ENCONTRADA");
                Console.ReadKey();
                return;
            }
            if (Resto.Mesas[mesaInt - 1] == true)
            {
                ImprimirLlenarMesa();
                WriteLineRed("\nLA MESA YA ESTA ABIERTA");
                Console.ReadKey();
                return;
            }

            Resto.Mesas[mesaInt - 1] = true;
            WriteLineGreen("\nMESA ABIERTA CON EXITO");
            Console.ReadKey();
            return;


        }
        /// <summary>
        /// Funcionamiento Principal de Vaciar Mesa
        /// </summary>
        static void VaciarMesa()
        {

            string mesa = "";
            int mesaInt = 100;
            bool prueba = false;

            ImprimirVaciarMesa();
            Console.Write("\n\nMESA: ");

            mesa = Console.ReadLine();
            prueba = int.TryParse(mesa, out mesaInt);
            if (mesaInt > 15 || prueba == false)
            {
                ImprimirLlenarMesa();
                WriteLineRed("\nMESA NO ENCONTRADA");
                Console.ReadKey();
                return;
            }
            if (Resto.Mesas[mesaInt - 1] == false)
            {
                ImprimirLlenarMesa();
                WriteLineRed("\nLA MESA YA ESTA CERRADA");
                Console.ReadKey();
                return;
            }

            Resto.Mesas[mesaInt - 1] = false;
            Resto.Ventas[ConseguirSecuencialDeMesaAbiertaEnVentas(mesaInt), 2] = -1;
            WriteLineGreen("\nMESA CERRADA CON EXITO");
            Console.ReadKey();
            return;



        }
        /// <summary>
        /// Funcionamiento Principal de Hacer Venta
        /// </summary>
        static void HacerVenta()
        {
            int[] Venta = new int[3];
            bool prueba = true;
            bool intento = false;
            bool intento2 = false;
            bool intento3 = false;
            string platoElegido = "C";

            ImprimirHacerVenta();

            Console.Write("\nMESA: ");
            prueba = int.TryParse(Console.ReadLine(), out int venta1);
            if (prueba == false)
            {
                WriteLineRed("LA MESA DEBE SER UN NUMERO");
                Console.ReadKey();
                return;
            }
            Venta[1] = venta1;
            int valido = CorroborarMesaVacia(Venta[1]);
            if (valido == 0)
            {
                int valido2 = CorroborarMesaNueva(Venta[1]);
                if (valido2 != 0)
                {
                    Venta[0] = Resto.Ventas[valido2, 0];
                }
                else if (valido2 == 0)
                {
                    Venta[0] = ConseguirSecuencialVacio(Ventas);
                }
                else
                {
                    WriteLineRed("ERROR AL BUSCAR MESA");
                    Console.ReadKey();
                    return;
                }
            }
            else if (valido == -1)
            {
                WriteLineRed("LA MESA ESTA CERRADA (NO HAY CLIENTES EN LA MESA)");
                Console.ReadKey();
                return;
            }
            else
            {
                WriteLineRed("ERROR AL BUSCAR MESA");
            }
            while (platoElegido.ToUpper() == "C")
            {
                ImprimirHacerVenta(Venta[1], Venta[0]);
                Console.Write("\nPLATO(Si aprieta 'C' podra ver la carta): ");
                platoElegido = Console.ReadLine();

                if (platoElegido.ToUpper() == "C")
                {
                    ImprimirMostrarPlatos();
                }
            }

            prueba = int.TryParse(platoElegido, out int platoElegidoNumero);
            while (intento == false)
            {
                if (prueba == false)
                {
                    WriteLineRed("EL PLATO DEBE SER UN NUMERO");
                    Console.ReadKey();
                    return;
                }
                valido = CorroborarPlatoExistente(platoElegido);
                if (valido == -1)
                {
                    intento2 = false;
                    while (intento2 == false)
                    {
                        Console.Write("\nEL PLATO NO EXISTE, DESEA VOLVER A INTENTAR? S/N: ");
                        string respuestaIntento = Console.ReadLine();
                        if (respuestaIntento.ToUpper() == "N")
                        {
                            return;
                        }
                        else if (respuestaIntento.ToUpper() == "S")
                        {
                            intento2 = true;
                            ImprimirHacerVenta(Venta[1], Venta[0]);
                            Console.Write("\nPLATO: ");
                            platoElegido = Console.ReadLine();

                            prueba = int.TryParse(platoElegido, out platoElegidoNumero);
                        }
                        else
                        {
                            Console.Write("\nNO SE RECONOCE LA RESPUESTA, VUELVA A INTENTAR: ");
                        }
                    }
                }
                else if (valido == 0)
                {
                    intento = true;
                }
            }

            Venta[2] = platoElegidoNumero;
            string nombrePlato = ConseguirNombrePlato(Venta[2]);
            ImprimirHacerVenta(Venta[1], Venta[0], Venta[2], ConseguirNombrePlato(Venta[2]), ConseguirPrecioPlato(Venta[2]));
            while (intento3 == false)
            {
                Console.Write("\nSeguro que quiere cargar la venta? S/N: ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "N")
                {
                    WriteLineRed("\nNO SE CARGO LA VENTA");
                    Console.ReadKey();
                    return;
                }
                else if (respuesta.ToUpper() == "S")
                {
                    CargarVenta(Venta);
                    WriteLineGreen("\nSE CARGO LA VENTA CON EXITO");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.Write("\nNO SE RECONOCE LA RESPUESTA, VUELVA A INTENTAR: ");
                }
            }







        }
        /// <summary>
        /// Funcionamiento Principal de Hacer Venta
        /// </summary>
        static void ConsultarVentas()
        {
            ImprimirConsultarVentas();
        }
        /// <summary>
        /// Funcionamiento Principal de Eliminar Venta
        /// </summary>
        static void EliminarVenta()
        {
            bool valida = false;
            string codigoBaja;

            ImprimirEliminarVenta();
            Console.Write("\nCODIGO A DAR DE BAJA: ");
            valida = int.TryParse(Console.ReadLine(), out int codigoBajaNumero);
            if (valida == false)
            {
                WriteLineRed("\nCODIGO ERRONEO");
                Console.ReadKey();
                return;
            }
            if (ValidarVenta(codigoBajaNumero) == -1)
            {
                WriteLineRed("\nCODIGO NO ENCONTRADO");
                Console.ReadKey();
                return;
            }

            while (true)
            {
                Console.Write($"\nSeguro que quiere dar la baja de la venta abierta N°: {codigoBajaNumero}? S/N: ");
                string respuestaIntento = Console.ReadLine();
                if (respuestaIntento.ToUpper() == "N")
                {
                    return;
                }
                else if (respuestaIntento.ToUpper() == "S")
                {
                    if (Resto.Ventas[codigoBajaNumero - 1, 2] == -1)
                    {
                        WriteLineRed("\nNO SE PUEDE DAR DE BAJA LA VENTA, YA SE HA EMITIDO LA FACTURA (CERRANDO LA MESA)");
                        Console.ReadKey();
                        return;
                    }
                    CargarEliminarVenta(codigoBajaNumero);
                    ImprimirEliminarVenta();
                    WriteLineGreen("\nVENTA ELIMINADA");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.Write("\nNO SE RECONOCE LA RESPUESTA. PRUEBE DE NUEVO: ");
                }
            }



        }
        /*<FUNCIONAMIENTO PANTALLAS/>*/

        /*----------------------------------------------------*/
        /*<FUNCIONAMIENTOS ADICIONALES>*/
        /// <summary>
        /// Acorta la palabra al tope dado como parametro. Se usa para que no se vayas de los limites por el sistema.
        /// </summary>
        /// <param name="palabra">Palabra a acortar</param>
        /// <param name="tope">Tope de Caracteres</param>
        /// <returns>Devuelve palabra acortada seguido por '...'</returns>
        static string ControlImpresionDePalabra(string palabra, int tope)
        {
            string aux = palabra;
            if (!string.IsNullOrEmpty(palabra))
            {
                if (palabra.Length > tope)
                {
                    aux = palabra.Substring(0, tope) + "...";
                    return aux;
                }
            }
            return aux;
        }

        /// <summary>
        /// Consigue un secuencial vacio de una matriz tipo string tipeada o mostrada
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns>Devuelve 0 si consigue un secuencial vacio y -1 si no</returns>
        static string ConseguirSecuencialVacio(String[,] matriz)
        {
            string aLlenar;
            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                if (string.IsNullOrEmpty(matriz[i, 0]))
                {
                    int nexo = i + 1;
                    aLlenar = nexo.ToString();
                    return aLlenar;
                }
            }
            return "-1";
        }

        /// <summary>
        /// Consigue un secuencial vacio de una matriz tipo int tipeada o mostrada
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns>Devuelve 0 si consigue un secuencial vacio y -1 si no</returns>
        static int ConseguirSecuencialVacio(int[,] matriz)
        {

            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                if (matriz[i, 0] == 0)
                {
                    int aLlenar = i + 1;
                    return aLlenar;
                }
            }
            return -1;
        }

        /// <summary>
        /// Corrobora que un secuencial en una matriz exista
        /// </summary>
        /// <param name="matriz">Matriz en la que buscar secuencial</param>
        /// <param name="secuencial">Secuencial a buscar</param>
        /// <returns>Devuelve 0 si matchea secuencial y -1 si no</returns>
        static int CorroborarSecuencial(string[,] matriz, string secuencial)
        {

            for (int i = 0; i < matriz.GetLength(0); ++i)
            {
                if (matriz[i, 0] == secuencial)
                {
                    return 0;
                }
            }
            return -1;
        }

        /// <summary>
        /// Busca el proximo secuencial vacio en la tabla de ventas.
        /// </summary>
        /// <param name="nVenta">Tabla intermedio en la que se pre-cargan los datos a subir a la venta</param>
        /// <returns>Devuelve el primer secuencial de venta que encuentre vacío</returns>
        static int ConseguirPlatoVacioEnVenta(int nVenta)
        {
            for (int i = 0; i < Resto.Ventas.GetLength(0); ++i)
            {
                if (Resto.Ventas[i, 0] == nVenta)
                {
                    for (int n = 3; n < Resto.Ventas.GetLength(1) - 3; n++)
                    {
                        if (Resto.Ventas[i, n] == 0)
                        {
                            return n;
                        }
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Consigue la mesa abierta que se este pasando
        /// </summary>
        /// <param name="mesa">Mesa a buscar</param>
        /// <returns>Si la encuentra pasa el numero de mesa, sino -1</returns>
        static int ConseguirSecuencialDeMesaAbiertaEnVentas(int mesa)
        {
            for (int i = 0; i < Resto.Ventas.GetLength(0); ++i)
            {
                if (Resto.Ventas[i, 1] == mesa && Resto.Ventas[i, 2] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Consigue una Fila de Platos.
        /// </summary>
        /// <param name="matriz">Matriz en la que buscar la fila</param>
        /// <param name="aBuscar">plato a buscar</param>
        /// <returns>Devuelve un string con la fila entera si se la encuentra, sino la devuelve vacía</returns>
        static string[] ConseguirFilaPlatos(String[,] matriz, string aBuscar)
        {
            {
                string[] aDevolver = new string[5] { "-1", "-1", "-1", "-1", "-1" };
                for (int i = 0; i < matriz.GetLength(0); ++i)
                {
                    if (matriz[i, 0] == aBuscar)
                    {
                        int nexo = i;
                        aDevolver[0] = Resto.Platos[nexo, 0];
                        aDevolver[1] = Resto.Platos[nexo, 1];
                        aDevolver[2] = Resto.Platos[nexo, 2];
                        aDevolver[3] = Resto.Platos[nexo, 3];
                        aDevolver[4] = Resto.Platos[nexo, 4];
                        return aDevolver;
                    }
                }
                return aDevolver;
            }
        }

        /// <summary>
        /// Se le asigna un simbolo a las mesas llenas y a las mesas vacias
        /// </summary>
        /// <param name="mesa">mesa a la que se le pasa el simbolo</param>
        /// <returns>Devuelve el simbolo segun corresponda</returns>
        static string AsignamientoDeMesas(bool mesa)
        {
            if (mesa == true)
            {
                return "XX";
            }
            else
            {
                return "  ";
            }
        }

        /// <summary>
        /// Imprime un Write Line en rojo
        /// </summary>
        /// <param name="negativo">Frase para pintar de rojo</param>
        static void WriteLineRed(string negativo)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(negativo);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Imprime un Write Line Pero en verde
        /// </summary>
        /// <param name="negativo">sentencia a pasar a verde</param>
        static void WriteLineGreen(string negativo)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(negativo);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Imprime una sentencia con el color de letra y fondo que se indique
        /// </summary>
        /// <param name="frase">sentencia a imprimir</param>
        /// <param name="color">Color de fondo</param>
        /// <param name="color2">Color de Letra</param>
        static void WriteBackground(string frase, ConsoleColor color, ConsoleColor color2)
        {
            Console.BackgroundColor = color;
            Console.ForegroundColor = color2;
            Console.Write(frase);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Valida que el codigo de venta recibido exista
        /// </summary>
        /// <param name="venta">Codigo de venta a validar</param>
        /// <returns>Si lo encuentra devuelve el codigo de venta encontrado, sino -1</returns>
        static int ValidarVenta(int venta)
        {
            for (int i = 0; i < Resto.Ventas.GetLength(0); i++)
            {
                if (i == venta)
                {
                    return i;
                }

            }
            return -1;
        }

        /// <summary>
        /// Corrobora si la mesa es nueva
        /// </summary>
        /// <param name="mesaACorroborar">Es la mesa a corroborar</param>
        /// <returns></returns>
        static int CorroborarMesaNueva(int mesaACorroborar)
        {
            for (int i = 0; i < Resto.Ventas.GetLength(0); ++i)
            {

                if (Resto.Ventas[i, 2] == 0 && Resto.Ventas[i, 1] == mesaACorroborar)
                {
                    return i;
                }
            }
            return 0;
        }

        /// <summary>
        /// Corrobora si la mesa pasada esta vacía
        /// </summary>
        /// <param name="mesaACorroborar">Mesa a corroborar</param>
        /// <returns>Devuelve 0 si esta llena, devuelve -1 si esta vacía</returns>
        static int CorroborarMesaVacia(int mesaACorroborar)
        {
            if (Resto.Mesas[mesaACorroborar - 1] == false)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Corrobora si un plato pasado por parametro existe
        /// </summary>
        /// <param name="platoACorroborar">Plato a corroborar</param>
        /// <returns>Devuelve 0 si existe, devuelve -1 si no</returns>
        static int CorroborarPlatoExistente(string platoACorroborar)
        {

            int.TryParse(platoACorroborar, out int platoACorroborarNumero);
            int posicionPlato = platoACorroborarNumero - 1;
            if (Resto.Platos[posicionPlato, 0] != null)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Consigue el nombre de un plato pasandole como parametro su numero
        /// </summary>
        /// <param name="nPlato">Numero de plato a buscar</param>
        /// <returns>Devuelve el nombre</returns>
        static string ConseguirNombrePlato(int nPlato)
        {
            string nombrePlato;
            int nPlatoSecuencial = nPlato - 1;
            nombrePlato = Resto.Platos[nPlatoSecuencial, 1];
            return nombrePlato;
        }

        /// <summary>
        /// Consigue el precio de un plato pasandole el numero del mismo como parametro
        /// </summary>
        /// <param name="nPlato">Numero de plato</param>
        /// <returns>Devuelve el precio</returns>
        static string ConseguirPrecioPlato(int nPlato)
        {
            string precioPlato;
            int nPlatoSecuencial = nPlato - 1;
            precioPlato = Resto.Platos[nPlatoSecuencial, 4];
            return precioPlato;
        }

        /// <summary>
        /// Ordena una matriz dada en una de sus columnas dada como parametro
        /// </summary>
        /// <param name="stringdata">matriz a ordenar</param>
        /// <param name="sortby">columna a ordenar</param>
        /// <returns>Devuelve la matriz dada como parametro pero ordenada por "sortby"</returns>
        static string[,] OrdenarMatriz(string[,] stringdata, string sortby)
        {
            string[,] resultado = new string[stringdata.GetLength(0), stringdata.GetLength(1)];
            DataTable dt = new DataTable();
            for (int col = 0; col < stringdata.GetLength(1); col++)
            {
                dt.Columns.Add(stringdata[0, col]);
            }
            for (int rowindex = 1; rowindex < stringdata.GetLength(0); rowindex++)
            {
                DataRow row = dt.NewRow();
                for (int col = 0; col < stringdata.GetLength(1); col++)
                {
                    row[col] = stringdata[rowindex, col];
                }
                dt.Rows.Add(row);
            }
            DataRow[] sortedrows = dt.Select("", $"{sortby} DESC");
            for (int i = 0; i < sortedrows.GetLength(0); i++)
            {
                for (int o = 0; o < sortedrows[i].ItemArray.GetLength(0); o++)
                {
                    resultado[i, o] = sortedrows[i].ItemArray[o].ToString();
                }
            }

            return resultado;
        }

        /*<FUNCIONAMIENTOS ADICIONALES/>*/


        /******************************************************/
        /****                DIBUJOS                       ****/
        /******************************************************/

        /*<DIBUJOS MENUES>*/
        /// <summary>
        /// Imprime el menu principal
        /// </summary>
        static void ImprimirMenu()
        {

            /*AGREGAR UN NOMBRE CON COLORES ESPECIALES EN BACKGROUND Y LETRA*/
            ImprimirLogo();
            WriteBackground("MENU\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________" +
                        "\n|              _____                               |" +
                        "\n|Bienvenido a ");
            MiniLogoMedio();
            Console.Write("                              | " +
            "\n|              ¯¯¯¯¯                               |" +
            "\n|Pulse el numero de la opcion que quiere aplicar:  |" +
            "\n|                                                  |" +
            "\n|1.Platos                                          |" +
            "\n|                                                  |" +
            "\n|2.Ventas                                          |" +
            "\n|                                                  |" +
            "\n|3.Listados                                        |" +
            "\n|                                                  |" +
            "\n|4.Reportes                                        |" +
            "\n|                                                  |" +
            "\n|8. SALIR DE LA APP                                |");
            ImprimirPie();
        }

        /// <summary>
        /// Imprime el Submenu Platos
        /// </summary>
        static void ImprimirSubMenuPlatos()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________" +
            "\n|1.ALTA                                            |" +
            "\n|                                                  |" +
            "\n|2.BAJA                                            |" +
            "\n|                                                  |" +
            "\n|3.CONSULTA                                        |" +
            "\n|                                                  |" +
            "\n|4.EDITAR PLATO                                    |" +
            "\n|                                                  |" +
            "\n|8.ATRAS                                           |");

            ImprimirPie();

        }

        /// <summary>
        /// Imprime el Submenu Ventas
        /// </summary>
        static void ImprimirSubMenuVentas()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("VENTAS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________" +
            "\n|1.AGREGAR VENTA                                   |" +
            "\n|                                                  |" +
            "\n|2.ELIMINAR VENTA                                  |" +
            "\n|                                                  |" +
            "\n|3.CONSULTAR VENTAS ABIERTAS                       |" +
            "\n|                                                  |" +
            "\n|4.ABRIR MESA                                      |" +
            "\n|                                                  |" +
            "\n|5.CERRAR MESA                                     |" +
            "\n|                                                  |" +
            "\n|6.VER SALON                                       |" +
            "\n|                                                  |" +
            "\n|8.ATRAS                                           |");
            ImprimirPie();

        }

        /// <summary>
        /// Imprime el Submenu Listados
        /// </summary>
        static void ImprimirSubMenuListados()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("LISTADOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________" +
            "\n|1.MOSTRAR PLATOS                                  |" +
            "\n|2.MOSTRAR PLATOS ORDENADOS P/CATEGORIA            |" +
            "\n|3.MOSTRAR PLATOS ORDENADOS P/ORDEN DE PRECIOS     |" +
            "\n|4.MOSTRAR VENTAS FACTURADAS(CON MESA CERRADA)     |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|8.ATRAS                                           |");
            ImprimirPie();

        }

        /// <summary>
        /// Imprime el Submenu Reportes
        /// </summary>
        static void ImprimirSubMenuReportes()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("REPORTES\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________" +
            "\n|1.REPORTE RATIO COSTO BENEFICIO POR PLATO         |" +
            "\n|2.REPORTE PLATOS MAS VENDIDOS                     |" +
            "\n|3.REPORTE PLATOS MAS VENDIDOS ORDENADOS P/CATEG   |" +
            "\n|4.REPORTE MARGEN DE GANANCIAS P/VENTAS            |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|8.ATRAS                                           |");
            ImprimirPie();

        }

        /// <summary>
        /// Imprime el la ultima pantalla antes de terminar el programa
        /// </summary>
        static void ImprimirFinalPrograma()
        {
            Console.Clear();
            /*AGREGAR UN NOMBRE CON COLORES ESPECIALES EN BACKGROUND Y LETRA*/
            ImprimirLogo();
            Console.WriteLine("" +
                "\n __________________________________________________" +
                "\n|Base de datos llevada a 'Estandar'.               |" +
                "\n|                                                  |" +
                "\n|Gracias por elegirnos! Hasta luego!               |" +
                "\n|_____                                             |");
            MiniLogoMedio();
            Console.Write("" +
            "                                            | " +
            "\n|¯¯¯¯¯                                             |");
            ImprimirPie();
            Console.ReadKey();
        }
        /*<DIBUJOS MENUES/>*/

        /*----------------------------------------------------*/
        /*<DIBUJOS PANTALLAS>*/
        /// <summary>
        /// Imprime Altas Platos
        /// </summary>
        /// <param name="secuencial">Secuencial del plato</param>
        static void ImprimirAltaPlatos(string secuencial)
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("ALTA PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________" +
           $"\n|CODIGO:              {ControlImpresionDePalabra(secuencial, 20),-23}      |" +
            "\n|NOMRBE:                                           |" +
            "\n|CATEGORIA:                                        |" +
            "\n|COSTO:                                            |" +
            "\n|PRECIO:                                           |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprime Altas Platos
        /// </summary>
        /// <param name="secuencial">Secuencial del plato</param>
        /// <param name="nombre">Nombre del Plato</param>
        static void ImprimirAltaPlatos(string secuencial, string nombre)
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("ALTA PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
           $"\n|CODIGO:              {ControlImpresionDePalabra(secuencial, 20),-23}      |" +
           $"\n|NOMRBE:              {ControlImpresionDePalabra(nombre, 20),-23}      |" +
            "\n|CATEGORIA:                                        |" +
            "\n|COSTO:                                            |" +
            "\n|PRECIO:                                           |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprime Altas Platos
        /// </summary>
        /// <param name="secuencial">Secuencial del plato</param>
        /// <param name="nombre">Nombre del plato</param>
        /// <param name="categoria">Categoria del plato</param>
        static void ImprimirAltaPlatos(string secuencial, string nombre, string categoria)
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("ALTA PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
           $"\n|CODIGO:              {ControlImpresionDePalabra(secuencial, 20),-23}      |" +
           $"\n|NOMRBE:              {ControlImpresionDePalabra(nombre, 20),-23}      |" +
           $"\n|CATEGORIA:           {ControlImpresionDePalabra(categoria, 20),-23}      |" +
            "\n|COSTO:                                            |" +
            "\n|PRECIO:                                           |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprime Altas Platos
        /// </summary>
        /// <param name="secuencial">Secuencial del plato</param>
        /// <param name="nombre">Nombre del plato</param>
        /// <param name="categoria">Categoria del plato</param>
        /// <param name="costo">Costo del plato</param>
        static void ImprimirAltaPlatos(string secuencial, string nombre, string categoria, string costo)
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("ALTA PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
           $"\n|CODIGO:              {ControlImpresionDePalabra(secuencial, 20),-23}      |" +
           $"\n|NOMRBE:              {ControlImpresionDePalabra(nombre, 20),-23}      |" +
           $"\n|CATEGORIA:           {ControlImpresionDePalabra(categoria, 20),-23}      |" +
           $"\n|COSTO:               {ControlImpresionDePalabra(costo, 20),-23}      |" +
            "\n|PRECIO:                                           |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprime Altas Platos
        /// </summary>
        /// <param name="secuencial">Secuencial del plato</param>
        /// <param name="nombre">Nombre del plato</param>
        /// <param name="categoria">Categoria del plato</param>
        /// <param name="costo">Costo del plato</param>
        /// <param name="precio">Precio del plato</param>
        static void ImprimirAltaPlatos(string secuencial, string nombre, string categoria, string costo, string precio)
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("ALTA PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
           $"\n|CODIGO:              {ControlImpresionDePalabra(secuencial, 20),-23}      |" +
           $"\n|NOMRBE:              {ControlImpresionDePalabra(nombre, 20),-23}      |" +
           $"\n|CATEGORIA:           {ControlImpresionDePalabra(categoria, 20),-23}      |" +
           $"\n|COSTO:               {ControlImpresionDePalabra(costo, 20),-23}      |" +
           $"\n|PRECIO:              {ControlImpresionDePalabra(precio, 20),-23}      |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprimir baja de plato vacia
        /// </summary>
        static void ImprimirBajaPlatos()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("BAJA PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________" +
           $"\n|CODIGO:                                           |" +
           $"\n|NOMRBE:                                           |" +
           $"\n|CATEGORIA:                                        |" +
           $"\n|COSTO:                                            |" +
           $"\n|PRECIO:                                           |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprime baja de plato llena
        /// </summary>
        /// <param name="secuencial">Secuencial del plato</param>
        /// <param name="nombre">Nombre del plato</param>
        /// <param name="categoria">Categoria del plato</param>
        /// <param name="costo">Costo del plato</param>
        /// <param name="precio">Precio del plato</param>
        static void ImprimirBajaPlatos(string secuencial, string nombre, string categoria, string costo, string precio)
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("BAJA PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
           $"\n|CODIGO:              {ControlImpresionDePalabra(secuencial, 20),-23}      |" +
           $"\n|NOMRBE:              {ControlImpresionDePalabra(nombre, 20),-23}      |" +
           $"\n|CATEGORIA:           {ControlImpresionDePalabra(categoria, 20),-23}      |" +
           $"\n|COSTO:               {ControlImpresionDePalabra(costo, 20),-23}      |" +
           $"\n|PRECIO:              {ControlImpresionDePalabra(precio, 20),-23}      |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");
            ImprimirPie();
        }

        /// <summary>
        /// Imprimir consulta de platos vacía
        /// </summary>
        static void ImprimirConsultaPlatos()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("CONSULTAR PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________" +
           $"\n|CODIGO:                                           |" +
           $"\n|NOMRBE:                                           |" +
           $"\n|CATEGORIA:                                        |" +
           $"\n|COSTO:                                            |" +
           $"\n|PRECIO:                                           |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprimir consulta de platos llena
        /// </summary>
        /// <param name="secuencial">Secuencial del plato</param>
        /// <param name="nombre">Nombre del plato</param>
        /// <param name="categoria">Categoria del plato</param>
        /// <param name="costo">Costo del plato</param>
        /// <param name="precio">Precio del plato</param>
        static void ImprimirConsultaPlatos(string secuencial, string nombre, string categoria, string costo, string precio)
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("CONSULTAR PLATOS\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
           $"\n|CODIGO:              {ControlImpresionDePalabra(secuencial, 20),-23}      |" +
           $"\n|NOMRBE:              {ControlImpresionDePalabra(nombre, 20),-23}      |" +
           $"\n|CATEGORIA:           {ControlImpresionDePalabra(categoria, 20),-23}      |" +
           $"\n|COSTO:               {ControlImpresionDePalabra(costo, 20),-23}      |" +
           $"\n|PRECIO:              {ControlImpresionDePalabra(precio, 20),-23}      |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");
            ImprimirPie();
        }

        /// <summary>
        /// Imprime el dibujo llena
        /// </summary>
        /// <param name="Mesa"></param>
        static void ImprimirDibujoSalon(bool[] Mesa)
        {
            {
                string d1 = AsignamientoDeMesas(Mesa[0]);
                string d2 = AsignamientoDeMesas(Mesa[1]);
                string d3 = AsignamientoDeMesas(Mesa[2]);
                string d4 = AsignamientoDeMesas(Mesa[3]);
                string d5 = AsignamientoDeMesas(Mesa[4]);
                string d6 = AsignamientoDeMesas(Mesa[5]);
                string d7 = AsignamientoDeMesas(Mesa[6]);
                string d8 = AsignamientoDeMesas(Mesa[7]);
                string d9 = AsignamientoDeMesas(Mesa[8]);
                string d10 = AsignamientoDeMesas(Mesa[9]);
                string d11 = AsignamientoDeMesas(Mesa[10]);
                string d12 = AsignamientoDeMesas(Mesa[11]);
                string d13 = AsignamientoDeMesas(Mesa[12]);
                string d14 = AsignamientoDeMesas(Mesa[13]);
                string d15 = AsignamientoDeMesas(Mesa[14]);

                Console.Clear();
                WriteBackground("SALON\n", ConsoleColor.White, ConsoleColor.Black);
                Console.Write("                                 PISO 1                                                           " +
                "\n __ENTRADA_________________________________________________________________                       " +
                "\n|                     |           BARRA             |                  __||    __                 " +
                "\n|                     |                             |               __|   |   |  |  MESA CERRADA  " +
                "\n|                      ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯              |      |   ¯¯¯¯                " +
                "\n|    __       __       __                 __       __       __            |    __                 " +
               $"\n|  1|{d1}|    2|{d2}|    3|{d3}|       __     7|{d7}|    8|{d8}|    9|{d9}|           |   |XX|  MESA ABIERTA  " +
               $"\n|   ¯¯¯¯     ¯¯¯¯     ¯¯¯¯      |{d6}|     ¯¯¯¯     ¯¯¯¯     ¯¯¯¯           |   ¯¯¯¯                " +
               $"\n|         __      __           6|{d6}|               __      __             |                       " +
               $"\n|       4|{d4}|   5|{d5}|           |{d6}|            10|{d10}|  11|{d11}|      ______|                       " +
                "\n|        ¯¯¯¯    ¯¯¯¯           ¯¯¯¯              ¯¯¯¯    ¯¯¯¯     | BAÑOS|                       " +
                "\n|_________________________________________________________________________\n\n\n");

                Console.Write
                 (
                  "                                                  PISO 2                                          " +
                "\n                                     ______________________________________                       " +
                "\n                                    |   |BAÑOS|  |                __      |                       " +
                "\n                                    |___|     |__|                  |__   |                       " +
                "\n                                    |                                  |__|                       " +
                "\n                                    |___                   __     __      |                       " +
               $"\n                                    |B  |   PISTA       12|{d12}| 13|{d13}|     |                       " +
                "\n                                    |A  |    DE           ¯¯¯¯   ¯¯¯¯     |                       " +
                "\n                                    |R  |   BAILE         __      __      |                       " +
               $"\n                                    |R  |              15|{d15}|  14|{d14}|     |                       " +
                "\n                                    |A  |                ¯¯¯¯    ¯¯¯¯     |                       " +
                "\n                                    |_____________________________________|");


                Console.ReadKey();
            }
        }

        /// <summary>
        /// Imprimir abrir mesa
        /// </summary>
        static void ImprimirLlenarMesa()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("ABRIR MESA\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
           $"\n|N° de mesa a abrir :                              |" +
           $"\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprmir cerrar mesa
        /// </summary>
        static void ImprimirVaciarMesa()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("CERRAR MESA\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
           $"\n|N° de mesa a cerrar:                              |" +
           $"\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprimir hacer venta
        /// </summary>
        static void ImprimirHacerVenta()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("AGREGAR VENTA\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
            "\n|MESA:                                             |" +
           $"\n|N° DE VENTA:                                      |" +
           $"\n|CODIGO PLATO:                                     |" +
           $"\n|NOMBRE PLATO:                                     |" +
           $"\n|PRECIO:                                           |" +
           $"\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprimir hacer venta
        /// </summary>
        /// <param name="mesa">Numero de mesa</param>
        /// <param name="venta">Numero de venta</param>
        static void ImprimirHacerVenta(int mesa, int venta)
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("AGREGAR VENTA\n", ConsoleColor.White, ConsoleColor.Black);
            Console.Write(" __________________________________________________ " +
           $"\n|MESA:                {mesa,-2}                           |" +
           $"\n|N° DE VENTA:         {venta,-2}                           |" +
           $"\n|CODIGO PLATO:                                     |" +
           $"\n|NOMBRE PLATO:                                     |" +
           $"\n|PRECIO:                                           |" +
           $"\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |" +
            "\n|                                                  |");

            ImprimirPie();
        }

        /// <summary>
        /// Imprimir hacer venta
        /// </summary>
        /// <param name="mesa">Numero de mesa</param>
        /// <param name="venta">Numero de venta</param>
        /// <param name="nPlato">Numero de Plato</param>
        /// <param name="nombrePlato">Nomrbe del Plato</param>
        /// <param name="precio">Precio del Plato</param>
        static void ImprimirHacerVenta(int mesa, int venta, int nPlato, string nombrePlato, string precio)
        {
            {
                Console.Clear();
                ImprimirLogo();
                WriteBackground("AGREGAR VENTA\n", ConsoleColor.White, ConsoleColor.Black);
                Console.Write(" __________________________________________________ " +
               $"\n|MESA:                {mesa,-2}                           |" +
               $"\n|N° DE VENTA:         {venta,-2}                           |" +
               $"\n|CODIGO PLATO:        {nPlato,-2}                           |" +
               $"\n|NOMBRE PLATO:        {ControlImpresionDePalabra(nombrePlato, 20),-23}      |" +
               $"\n|PRECIO:              {precio,-20}         |" +
               $"\n|                                                  |" +
                "\n|                                                  |" +
                "\n|                                                  |" +
                "\n|                                                  |" +
                "\n|                                                  |");

                ImprimirPie();
            }
        }

        /// <summary>
        /// Consulta de venta vacia
        /// </summary>
        static void ImprimirConsultarVentas()
        {

            Console.Clear();
            ImprimirLogo();
            WriteBackground("Consultar Ventas con Mesas Abiertas\n", ConsoleColor.White, ConsoleColor.Black);
            ImprimirCabeceraListado(new string[3] {
                 "ID Venta",
                 "Mesa",
                 "Pedidos"},
                ConsoleColor.DarkBlue
            );
            Console.WriteLine("");

            for (int i = 0; i < Resto.Ventas.GetLength(0) - 1; i++)
            {
                if (Resto.Ventas[i, 2] == 0 && Resto.Ventas[i, 0] != 0)
                {
                    for (int o = 0; o < Resto.Ventas.GetLength(1); o++)
                    {
                        if (Resto.Ventas[i, o] == 0)
                        {
                            int duumy;
                        }
                        else
                        {
                            if (o == 3)
                            {
                                Console.Write($"{ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 1], 20),-23}|");
                            }
                            else if (o > 3)
                            {

                                Console.Write($"\n{"",47}|{ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 1], 20),-23}|");
                            }
                            else
                            {
                                Console.Write($"{Resto.Ventas[i, o],-23}|");
                            }

                        }

                    }
                    Console.Write("\n");
                }
            }
            ImprimirPie();
            Console.ReadKey();
        }

        /// <summary>
        /// Imprime la cabecera cabecera de los listados
        /// </summary>
        /// <param name="cabecera">String de nombres de cabeceras</param>
        /// <param name="color">Color del que se quiera poner el fondo</param>
        static void ImprimirCabeceraListado(string[] cabecera, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            for (int i = 0; i < cabecera.Length; i++)
            {
                Console.Write($"{cabecera[i],23}|");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /// <summary>
        /// Imprimir Eliminar Venta
        /// </summary>
        static void ImprimirEliminarVenta()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground
             ("Eliminar Venta\n", ConsoleColor.White, ConsoleColor.Black);
            ImprimirCabeceraListado(new string[3] {
                 "ID Venta",
                 "Mesa",
                 "Pedidos"},
                ConsoleColor.DarkBlue
            );
            Console.WriteLine("");

            for (int i = 0; i < Resto.Ventas.GetLength(0) - 1; i++)
            {
                if (Resto.Ventas[i, 2] == 0 && Resto.Ventas[i, 0] != 0)
                {
                    for (int o = 0; o < Resto.Ventas.GetLength(1); o++)
                    {
                        if (Resto.Ventas[i, o] == 0)
                        {
                            int duumy;
                        }
                        else
                        {
                            if (o == 3)
                            {
                                Console.Write($"{ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 1], 20),23}|");
                            }
                            else if (o > 3)
                            {

                                Console.Write($"\n{"",47}|{ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 1], 20),23}|");
                            }
                            else
                            {
                                Console.Write($"{Resto.Ventas[i, o],23}|");
                            }

                        }

                    }
                    Console.Write("\n");
                }
            }
            ImprimirPie();
        }

        /// <summary>
        /// Imprimir mostrar platos
        /// </summary>
        static void ImprimirMostrarPlatos()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("MOSTRAR PLATOS\n", ConsoleColor.White, ConsoleColor.Black);

            string[] cabecera = new string[5]
            {
                "ID",
                "Nombre Plato",
                "Categoria",
                "Costo",
                "Precio"
            };
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < cabecera.Length; i++)
            {
                if (i == 1 || i == 2)
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 20),23}|");
                }
                else
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 9),12}|");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            for (int i = 0; i < Resto.Platos.GetLength(0); i++)
            {
                if (Resto.Platos[i, 1] != null)
                {
                    for (int o = 0; o < Resto.Platos.GetLength(1); o++)
                    {
                        if (o == 1 || o == 2)
                        {
                            Console.Write($"{ControlImpresionDePalabra(Resto.Platos[i, o], 20),23}|");
                        }
                        else
                        {
                            Console.Write($"{ControlImpresionDePalabra(Resto.Platos[i, o], 9),12}|");
                        }
                    }
                    Console.Write("\n");
                }
            }
            ImprimirPie();
            Console.ReadKey();
        }

        /// <summary>
        /// Imprimir matriz de platos por una columna dada
        /// </summary>
        /// <param name="ordenadoPor">Columna parametro para ordenar</param>
        static void ImprimirPlatosOP(string ordenadoPor)
        {
            string[,] platos = new string[26, 5];
            for (int i = 0; i < platos.GetLength(0); i++)
            {
                if (i <= 24)
                {
                    for (int o = 0; o < Resto.Platos.GetLength(1); o++)
                    {
                        platos[i, o] = Resto.Platos[i, o];
                    }
                }
                if (i == 25)
                {
                    for (int o = 0; o < platos.GetLength(1); o++)
                    {
                        platos[i, o] = null;
                    }
                }
            }
            platos[25, 0] = platos[0, 0];
            platos[25, 1] = platos[0, 1];
            platos[25, 2] = platos[0, 2];
            platos[25, 3] = platos[0, 3];
            platos[25, 4] = platos[0, 4];
            Console.Clear();
            ImprimirLogo();
            WriteBackground("MOSTRAR PLATOS\n", ConsoleColor.White, ConsoleColor.Black);

            string[] cabecera = new string[5]
            {
                "ID",
                "Nombre Plato",
                "Categoria",
                "Costo",
                "Precio"
            };
            platos[0, 0] = cabecera[0];
            platos[0, 1] = cabecera[1];
            platos[0, 2] = cabecera[2];
            platos[0, 3] = cabecera[3];
            platos[0, 4] = cabecera[4];

            platos = OrdenarMatriz(platos, ordenadoPor);

            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < cabecera.Length; i++)
            {
                if (i == 1 || i == 2)
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 20),23}|");
                }
                else
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 9),12}|");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");


            for (int i = 1; i < platos.GetLength(0); i++)
            {
                if (platos[i, 1] != null && platos[i, 1] != "")
                {
                    for (int o = 0; o < platos.GetLength(1); o++)
                    {
                        if (o == 1 || o == 2)
                        {
                            Console.Write($"{ControlImpresionDePalabra(platos[i, o], 20),23}|");
                        }
                        else
                        {
                            Console.Write($"{ControlImpresionDePalabra(platos[i, o], 9),12}|");
                        }
                    }
                    Console.Write("\n");
                }
            }
            ImprimirPie();
            Console.ReadKey();
        }

        /// <summary>
        /// Imprimir Mostrar Venta
        /// </summary>
        static void ImprimirMostrarVentas()
        {
            int suma = 0;
            int sumaFactura = 0;
            Console.Clear();
            ImprimirLogo();
            WriteBackground("Consultar Ventas con Mesas Abiertas\n", ConsoleColor.White, ConsoleColor.Black);
            ImprimirCabeceraListado(new string[4] {
                 "ID Venta",
                 "Mesa",
                 "Pedidos",
                 "Precio"},
                ConsoleColor.DarkBlue
            );
            Console.WriteLine("");

            for (int i = 0; i < Resto.Ventas.GetLength(0) - 1; i++)
            {
                if (Resto.Ventas[i, 2] == -1 && Resto.Ventas[i, 0] != 0)
                {
                    sumaFactura = 0;
                    for (int o = 0; o < Resto.Ventas.GetLength(1); o++)
                    {
                        if (Resto.Ventas[i, o] == -1 || Resto.Ventas[i, o] == 0)
                        {
                            int duumy;
                        }
                        else
                        {
                            if (o == 3)
                            {
                                Console.Write($"{ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 1], 20),-23}|");
                                Console.Write($"${ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 4], 20),-23}|");
                                int.TryParse(Resto.Platos[Resto.Ventas[i, o] - 1, 4], out int precio);
                                suma += precio;
                                sumaFactura += precio;

                            }
                            else if (o > 3)
                            {

                                Console.Write($"\n{"",47}|{ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 1], 20),-23}|");
                                Console.Write($"${ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 4], 20),-23}|");
                                int.TryParse(Resto.Platos[Resto.Ventas[i, o] - 1, 4], out int precio);
                                suma += precio;
                                sumaFactura += precio;
                            }
                            else
                            {
                                Console.Write($"{Resto.Ventas[i, o],-23}|");
                            }

                        }

                    }
                    Console.Write($"\n{"",71}|TOTAL FACTURA: ${sumaFactura,-8}|");
                    Console.Write("\n________________________________________________________________________________________________");
                    Console.Write("\n");
                }
            }
            WriteLineGreen($"{"",71}|TOTAL: ${suma,-16}|");
            ImprimirPie();
            Console.ReadKey();
        }

        /// <summary>
        /// Imprimir Margen de Ganancias
        /// </summary>
        static void ImprimirMostrarCostoBeneficioVenta()
        {
            int suma = 0;
            int sumaFactura = 0;
            Console.Clear();
            ImprimirLogo();
            WriteBackground("MARGEN DE GANANCIA DE LAS VENTAS\n", ConsoleColor.White, ConsoleColor.Black);
            ImprimirCabeceraListado(new string[4] {
                 "ID Venta",
                 "Mesa",
                 "Pedidos",
                 "Margen de Ganancia"},
                ConsoleColor.DarkBlue
            );
            Console.WriteLine("");

            for (int i = 0; i < Resto.Ventas.GetLength(0) - 1; i++)
            {
                if (Resto.Ventas[i, 2] == -1 && Resto.Ventas[i, 0] != 0)
                {
                    sumaFactura = 0;
                    for (int o = 0; o < Resto.Ventas.GetLength(1); o++)
                    {
                        if (Resto.Ventas[i, o] == -1 || Resto.Ventas[i, o] == 0)
                        {
                            int duumy;
                        }
                        else
                        {
                            if (o == 3)
                            {
                                int.TryParse(Resto.Platos[Resto.Ventas[i, o] - 1, 4], out int precio);
                                int.TryParse(Resto.Platos[Resto.Ventas[i, o] - 1, 3], out int costo);

                                Console.Write($"{ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 1], 20),-23}|");
                                Console.Write($"${ControlImpresionDePalabra((precio - costo).ToString(), 20),-23}|");
                                suma += precio - costo;
                                sumaFactura += precio - costo;

                            }
                            else if (o > 3)
                            {
                                int.TryParse(Resto.Platos[Resto.Ventas[i, o] - 1, 4], out int precio);
                                int.TryParse(Resto.Platos[Resto.Ventas[i, o] - 1, 3], out int costo);
                                Console.Write($"\n{"",47}|{ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 1], 20),-23}|");
                                Console.Write($"${ControlImpresionDePalabra(Resto.Platos[Resto.Ventas[i, o] - 1, 4], 20),-23}|");
                                suma += precio - costo;
                                sumaFactura += precio - costo;
                            }
                            else
                            {
                                Console.Write($"{Resto.Ventas[i, o],-23}|");
                            }

                        }

                    }
                    Console.Write($"\n{"",71}|TOTAL FACTURA: ${sumaFactura,-8}|");
                    Console.Write("\n________________________________________________________________________________________________");
                    Console.Write("\n");
                }
            }
            WriteLineGreen($"{"",71}|TOTAL: ${suma,-16}|");
            ImprimirPie();
            Console.ReadKey();
        }

        /// <summary>
        /// Imprimir Ratio Costo Beneficio por platos
        /// </summary>
        static void ImprimirMostrarCostoBeneficioPlatos()
        {
            Console.Clear();
            ImprimirLogo();
            WriteBackground("RATIO COSTO BENEFICIO\n", ConsoleColor.White, ConsoleColor.Black);

            string[] cabecera = new string[4]
            {
                "ID",
                "Nombre Plato",
                "Categoria",
                "B/C"
            };
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < cabecera.Length; i++)
            {
                if (i == 1 || i == 2)
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 20),23}|");
                }
                else
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 9),12}|");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");

            for (int i = 0; i < Resto.Platos.GetLength(0); i++)
            {
                if (Resto.Platos[i, 1] != null)
                {
                    for (int o = 0; o < Resto.Platos.GetLength(1) - 1; o++)
                    {
                        if (o == 1 || o == 2)
                        {
                            Console.Write($"{ControlImpresionDePalabra(Resto.Platos[i, o], 20),23}|");
                        }
                        else if (o == 3)
                        {
                            double.TryParse(Resto.Platos[i, o], out double costo);
                            double.TryParse(Resto.Platos[i, o + 1], out double precio);
                            double ratio = precio / costo;
                            Console.Write($"{ControlImpresionDePalabra(ratio.ToString(), 9),12}|");
                        }
                        else
                        {
                            Console.Write($"{ControlImpresionDePalabra(Resto.Platos[i, o], 9),12}|");
                        }
                    }
                    Console.Write("\n");
                }
            }
            ImprimirPie();
            Console.ReadKey();
        }

        /// <summary>
        /// Imprimir mostrar platos mas vendidos
        /// </summary>
        static void ImprimirMostrarPlatosMasVendidos()
        {
            string[,] platosMasVendidos = new string[Resto.Platos.GetLength(0) + 1, 4];

            Console.Clear();
            ImprimirLogo();
            WriteBackground("MOSTRAR PLATOS MAS VENDIDOS\n", ConsoleColor.White, ConsoleColor.Black);

            for (int i = 0; i < Resto.Platos.GetLength(0); i++)
            {
                for (int o = 0; o < Resto.Ventas.GetLength(0); o++)
                {
                    for (int u = 3; u < Resto.Ventas.GetLength(1); u++)
                    {
                        if (Resto.Platos[i, 0] == Resto.Ventas[o, u].ToString())
                        {
                            if (CorroborarSecuencial(platosMasVendidos, Resto.Platos[i, 0]) == 0)
                            {
                                int.TryParse(platosMasVendidos[i, 3], out int nexo);
                                nexo += 1;
                                platosMasVendidos[i, 3] = nexo.ToString();
                            }
                            else
                            {
                                platosMasVendidos[i, 0] = Resto.Platos[i, 0];
                                platosMasVendidos[i, 1] = Resto.Platos[i, 1];
                                platosMasVendidos[i, 2] = Resto.Platos[i, 2];
                                platosMasVendidos[i, 3] = "1";
                            }
                        }
                    }
                }
            }

            string[] cabecera = new string[4]
            {
                "ID",
                "Nombre Plato",
                "Categoria",
                "Vendidos"
            };
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < cabecera.Length; i++)
            {
                if (i == 1 || i == 2)
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 20),23}|");
                }
                else
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 9),12}|");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            platosMasVendidos[25, 0] = platosMasVendidos[0, 0];
            platosMasVendidos[25, 1] = platosMasVendidos[0, 1];
            platosMasVendidos[25, 2] = platosMasVendidos[0, 2];
            platosMasVendidos[25, 3] = platosMasVendidos[0, 3];

            platosMasVendidos[0, 0] = "ID";
            platosMasVendidos[0, 1] = "Nombre Plato";
            platosMasVendidos[0, 2] = "Categoria";
            platosMasVendidos[0, 3] = "Vendidos";
            platosMasVendidos = OrdenarMatriz(platosMasVendidos, "Vendidos");
            for (int i = 0; i < platosMasVendidos.GetLength(0); i++)
            {
                if (!String.IsNullOrEmpty(platosMasVendidos[i, 0]))
                {
                    for (int o = 0; o < platosMasVendidos.GetLength(1); o++)
                    {
                        if (o == 1 || o == 2)
                        {
                            Console.Write($"{ControlImpresionDePalabra(platosMasVendidos[i, o], 20),23}|");
                        }
                        else
                        {
                            Console.Write($"{ControlImpresionDePalabra(platosMasVendidos[i, o], 9),12}|");
                        }
                    }
                    Console.Write("\n");
                }
            }
            ImprimirPie();
            Console.ReadKey();
        }

        /// <summary>
        /// Imprimir mostrar las ventas ordenadas por categoria
        /// </summary>
        static void ImprimirMostrarCategoriasMasVendidas()
        {
            string[,] platosMasVendidos = new string[Resto.Platos.GetLength(0) + 1, 4];

            Console.Clear();
            ImprimirLogo();
            WriteBackground("MOSTRAR PLATOS MAS VENDIDOS\n", ConsoleColor.White, ConsoleColor.Black);

            for (int i = 0; i < Resto.Platos.GetLength(0); i++)
            {
                for (int o = 0; o < Resto.Ventas.GetLength(0); o++)
                {
                    for (int u = 3; u < Resto.Ventas.GetLength(1); u++)
                    {
                        if (Resto.Platos[i, 0] == Resto.Ventas[o, u].ToString())
                        {
                            if (CorroborarSecuencial(platosMasVendidos, Resto.Platos[i, 0]) == 0)
                            {
                                int.TryParse(platosMasVendidos[i, 3], out int nexo);
                                nexo += 1;
                                platosMasVendidos[i, 3] = nexo.ToString();
                            }
                            else
                            {
                                platosMasVendidos[i, 0] = Resto.Platos[i, 0];
                                platosMasVendidos[i, 1] = Resto.Platos[i, 1];
                                platosMasVendidos[i, 2] = Resto.Platos[i, 2];
                                platosMasVendidos[i, 3] = "1";
                            }
                        }
                    }
                }
            }

            string[] cabecera = new string[4]
            {
                "ID",
                "Nombre Plato",
                "Categoria",
                "Vendidos"
            };
            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < cabecera.Length; i++)
            {
                if (i == 1 || i == 2)
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 20),23}|");
                }
                else
                {
                    Console.Write($"{ControlImpresionDePalabra(cabecera[i], 9),12}|");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            platosMasVendidos[25, 0] = platosMasVendidos[0, 0];
            platosMasVendidos[25, 1] = platosMasVendidos[0, 1];
            platosMasVendidos[25, 2] = platosMasVendidos[0, 2];
            platosMasVendidos[25, 3] = platosMasVendidos[0, 3];

            platosMasVendidos[0, 0] = "ID";
            platosMasVendidos[0, 1] = "Nombre Plato";
            platosMasVendidos[0, 2] = "Categoria";
            platosMasVendidos[0, 3] = "Vendidos";
            platosMasVendidos = OrdenarMatriz(platosMasVendidos, "Categoria");
            for (int i = 0; i < platosMasVendidos.GetLength(0); i++)
            {
                if (!String.IsNullOrEmpty(platosMasVendidos[i, 0]))
                {
                    for (int o = 0; o < platosMasVendidos.GetLength(1); o++)
                    {
                        if (o == 1 || o == 2)
                        {
                            Console.Write($"{ControlImpresionDePalabra(platosMasVendidos[i, o], 20),23}|");
                        }
                        else
                        {
                            Console.Write($"{ControlImpresionDePalabra(platosMasVendidos[i, o], 9),12}|");
                        }
                    }
                    Console.Write("\n");
                }
            }
            ImprimirPie();
            Console.ReadKey();
        }

        /*<DIBUJOS PANTALLAS/>*/

        /*----------------------------------------------------*/
        /*<DIBUJO / DETALLE>*/

        /// <summary>
        /// Imprime el logo para la cabecera
        /// </summary>
        static void ImprimirLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(
                     "|¯¯¯¯¯¯|__   __|¯¯ ___ ¯¯¯¯    ¯|¯¯__¯¯¯¯¯¯¯¯¯¯¯¯¯¯|" +
                   "\n|         | |     |   |    |__    |__              |" +
                   "\n|         | |     |___|    |__|    __|             |" +
                   "\n ¯¯¯¯¯¯¯¯¯   ¯¯¯¯      ¯¯¯¯    ¯¯¯¯   ¯¯¯¯¯¯¯¯¯¯¯¯¯ ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Imprime el mini logo
        /// </summary>
        static void MiniLogoMedio()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("|Tob'S|");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        /// <summary>
        /// Imprimir Pie de Menues
        /// </summary>
        static void ImprimirPie()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(
            "\n|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|" +
            "\n|By TobiasCasazzaEnterprice                        |" +
            "\n|__________________________________________________|" +
            "\n                                                    ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        /*<DIBUJO / DETALLE/>*/



        /******************************************************/
        /****                CARGAS                        ****/
        /******************************************************/

        /*<CARGAS*/
        /// <summary>
        /// Carga inicial de platos
        /// </summary>
        /// <returns>Devuelve la carga inicial de platos</returns>
        static string[,] CargarPlatos()
        {
            String[,] Platos = new string[25, 5]
            {
                {"1","Hamburguesa Simple", "Hamburguesas","150", "400" },
                {"2","Hamburguesa Completa", "Hamburguesas","200", "600" },
                {null,null, null, null, null},
                {"4","Milanesa", "Milanesas","250", "500" },
                {"5","Milanesa Napolitana", "Milanesas","260", "550" },
                {"6","Milanesa a Caballo", "Milanesas","300", "600" },
                {null,null, null, null, null},
                {"8","Ensalada Cesar", "Saludable","150", "300" },
                {"9","Ensalada Rusa", "Saludable","150", "350" },
                {null,null, null, null, null},
                {"11","Arma tu Ensalada", "Saludable","200", "400" },
                {"12","Vacio", "Parrilla","250", "500" },
                {"13","Entraña", "Parrilla","300", "600" },
                {null,null, null, null, null},
                {"15","Tira de Asado", "Parrilla","250", "550" },
                {"16","Papas Fritas","Acompáñamiento" ,"150", "300" },
                {"17","Pure de Papa", "Acompañamiento","120", "300" },
                {"18","Chorizo", "Entrada Parrilla","100", "200"},
                {"19","Morzilla", "Entrada Parrilla","100", "200" },
                {"20","Agua 600cc", "Bebida", "50", "150"},
                {"21","Coca-Cola 600cc", "Bebida", "70", "200"},
                {"22","Agua 1,5l", "Bebida", "80", "200"},
                {"23","Coca-Cola 1,5l", "Bebida", "120", "300"},
                {null,null, null, null, null},
                {null,null, null, null, null}


            };
            return Platos;
        }

        /// <summary>
        /// Carga inicial de ventas
        /// </summary>
        /// <returns>Devuelve la carga inicial de ventas</returns>
        static int[,] CargarVentas()
        {
            int[,] Ventas = new int[50, 18]
            {
                { 1,13,-1,1,2,23,23,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 3,6,-1,5, 8, 22, 22, 0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 5,6,-1,5, 8, 22, 22, 22,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
            };
            return Ventas;

        }

        /// <summary>
        /// Carga el alta al finalizar la pantalla
        /// </summary>
        /// <param name="cargarPlato">string[] nexo para despues cargar a la base </param>
        static void CargarAlta(string[] cargarPlato)
        {
            int.TryParse(cargarPlato[0], out int secuencial);
            secuencial = secuencial - 1;
            Resto.Platos[secuencial, 0] = cargarPlato[0];
            Resto.Platos[secuencial, 1] = cargarPlato[1];
            Resto.Platos[secuencial, 2] = cargarPlato[2];
            Resto.Platos[secuencial, 3] = cargarPlato[3];
            Resto.Platos[secuencial, 4] = cargarPlato[4];

        }

        /// <summary>
        /// Carga el alta al finalizar la pantalla
        /// </summary>
        /// <param name="bajarPlato">string[] nexo para despues cargar a la base </param>
        static void CargarBaja(string[] bajarPlato)
        {
            int.TryParse(bajarPlato[0], out int secuencial);
            secuencial = secuencial - 1;
            Resto.Platos[secuencial, 0] = null;
            Resto.Platos[secuencial, 1] = null;
            Resto.Platos[secuencial, 2] = null;
            Resto.Platos[secuencial, 3] = null;
            Resto.Platos[secuencial, 4] = null;

        }

        /// <summary>
        /// Carga la venta al finalizar la pantalla
        /// </summary>
        /// <param name="cargarVenta">int[] nexo para despues cargar a la base </param>
        static void CargarVenta(int[] cargarVenta)
        {
            int secuencial = cargarVenta[0] - 1;
            Resto.Ventas[secuencial, 0] = cargarVenta[0];
            Resto.Ventas[secuencial, 1] = cargarVenta[1];
            Resto.Ventas[secuencial, ConseguirPlatoVacioEnVenta(cargarVenta[0])] = cargarVenta[2];
        }

        /// <summary>
        /// Carga la eliminacion de la venta al finalizar la pantalla
        /// </summary>
        /// <param name="IdaEliminar">int[] nexo para despues cargar a la base</param>
        static void CargarEliminarVenta(int IdaEliminar)
        {
            int secuencial = IdaEliminar;
            Resto.Ventas[secuencial - 1, 0] = 0;
            Resto.Ventas[secuencial - 1, 1] = 0;
            Resto.Ventas[secuencial - 1, 2] = 0;
            Resto.Ventas[secuencial - 1, 3] = 0;
            Resto.Ventas[secuencial - 1, 4] = 0;
            Resto.Ventas[secuencial - 1, 5] = 0;
            Resto.Ventas[secuencial - 1, 6] = 0;
            Resto.Ventas[secuencial - 1, 7] = 0;
            Resto.Ventas[secuencial - 1, 8] = 0;
            Resto.Ventas[secuencial - 1, 9] = 0;
            Resto.Ventas[secuencial - 1, 10] = 0;
            Resto.Ventas[secuencial - 1, 11] = 0;
            Resto.Ventas[secuencial - 1, 12] = 0;
            Resto.Ventas[secuencial - 1, 13] = 0;
            Resto.Ventas[secuencial - 1, 14] = 0;
            Resto.Ventas[secuencial - 1, 15] = 0;
            Resto.Ventas[secuencial - 1, 16] = 0;
            Resto.Ventas[secuencial - 1, 17] = 0;
        }
        /*<CARGAS INICIALES FIN/>*

        /*----------------------------------------------------*/
        static void Main(string[] args)
        {
            Programa();
        }
    }
}

