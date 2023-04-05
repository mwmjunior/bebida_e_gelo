

Console.Write (@$"
--------------------------------------------------------------------------------------------------
                     Programa para  servir bebidas e adicionar gelo  1.0                        
--------------------------------------------------------------------------------------------------
");

//************************************** ENTRADA DE DADOS ********************************************//

//******** DECLARAÇÃO DAS VARIÁVEIS **********//
string gelo;
int bebida;


    Console.WriteLine (@$"
____________________________________________________________________
|                     MENU DE OPÇÕES DE BEBIDAS                    |
|------------------------------------------------------------------|
|               BEBIDA                  |           OPÇÃO          |
|------------------------------------------------------------------|
|              COCA-COLA                |            1             |
|               SPRITE                  |            2             |
|              FANTA-UVA                |            3             |
|             FANTA LARANJA             |            4             |
|           GUARANÁ ANTARCTICA          |            5             |
|             PESPSI-COLA               |            6             |
|__________________________________________________________________|
");


    
    Console.Write("Digite o número da bebida desejada: ");
    bebida = int.Parse (Console.ReadLine()) ;

    Console.WriteLine("");

    Console.Write($"Deseja um adicional de gelo em sua bebida (S/N) ?: ");
    gelo = (Console.ReadLine()) .ToUpper ();
   
    Console.WriteLine("");

    Console.Clear();


    
//*************************************** PROCESSAMENTO DE DADOS ******************************************//

        switch (bebida)
        {
            case 1 :
                Console.Write(@$"
                ________________________________________________________________________
                |                                                                      |
                |               A BEBIDA ESCOLHIDA FOI COCA-COLA                       |
                ");
                break;

            case  2:
                Console.Write(@$"
                ________________________________________________________________________
                |                                                                      |
                |                 A BEBIDA ESCOLHIDA FOI SPRITE                        |
                ");
                break;

             case 3:
                Console.Write(@$"
                ________________________________________________________________________
                |                                                                      |
                |               A BEBIDA ESCOLHIDA FOI FANTA-UVA                       |
                ");
                break;
            
             case 4:
                Console.Write(@$"
                ________________________________________________________________________
                |                                                                      |
                |               A BEBIDA ESCOLHIDA FOI FANTA-LARANJA                   |
                ");
                break;

             case 5:
                Console.Write(@$"
                ________________________________________________________________________
                |                                                                      |
                |               A BEBIDA ESCOLHIDA FOI  GUARANÁ ANTARCTICA             |
                ");
                break;

             case 6:
                Console.Write(@$"
                ________________________________________________________________________
                |                                                                      |
                |               A BEBIDA ESCOLHIDA FOI  PEPSI-COLA                     |
                ");
                break;

            default:
                 Console.Write(@$"
                ________________________________________________________________________
                |                                                                      |
                |          NÃO EXISTEM OPÇÕES DE BEBDIDA COM ESSE NUMERO !             |
                ");
                break;
        }    


    
        switch (gelo)
        {
            case "S" :
                Console.Write(@$"
                |                     COM ADICIONAL DE GELO                            |
                |______________________________________________________________________|
                ");
                break;

            case "N" :
                Console.Write(@$"
                |                     SEM ADICIONAL DE GELO                            |
                |______________________________________________________________________|
                ");
                break;


            default:
                Console.Write(@$"
                |           DIGITE CORRETAMENTE A OPÇÃO DE ADICIONAR GELO !            |
                |______________________________________________________________________|
                ");
                break;
        }    


    Console.WriteLine("\nPressione qualquer tecla para sair...");

    Console.ReadKey();


