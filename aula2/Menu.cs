namespace menu;
public static class Menu {
    public static void Print() {
        Console.WriteLine(@"
          _____                   _______                   _____                    _____                    _____          
         /\    \                 /::\    \                 /\    \                  /\    \                  /\    \         
        /::\    \               /::::\    \               /::\    \                /::\    \                /::\____\        
       /::::\    \             /::::::\    \             /::::\    \              /::::\    \              /:::/    /        
      /::::::\    \           /::::::::\    \           /::::::\    \            /::::::\    \            /:::/    /         
     /:::/\:::\    \         /:::/~~\:::\    \         /:::/\:::\    \          /:::/\:::\    \          /:::/    /          
    /:::/__\:::\    \       /:::/    \:::\    \       /:::/__\:::\    \        /:::/  \:::\    \        /:::/____/           
   /::::\   \:::\    \     /:::/    / \:::\    \      \:::\   \:::\    \      /:::/    \:::\    \      /::::\    \           
  /::::::\   \:::\    \   /:::/____/   \:::\____\   ___\:::\   \:::\    \    /:::/    / \:::\    \    /::::::\    \   _____  
 /:::/\:::\   \:::\ ___\ |:::|    |     |:::|    | /\   \:::\   \:::\    \  /:::/    /   \:::\    \  /:::/\:::\    \ /\    \ 
/:::/__\:::\   \:::|    ||:::|____|     |:::|    |/::\   \:::\   \:::\____\/:::/____/     \:::\____\/:::/  \:::\    /::\____\
\:::\   \:::\  /:::|____| \:::\    \   /:::/    / \:::\   \:::\   \::/    /\:::\    \      \::/    /\::/    \:::\  /:::/    /
 \:::\   \:::\/:::/    /   \:::\    \ /:::/    /   \:::\   \:::\   \/____/  \:::\    \      \/____/  \/____/ \:::\/:::/    / 
  \:::\   \::::::/    /     \:::\    /:::/    /     \:::\   \:::\    \       \:::\    \                       \::::::/    /  
   \:::\   \::::/    /       \:::\__/:::/    /       \:::\   \:::\____\       \:::\    \                       \::::/    /   
    \:::\  /:::/    /         \::::::::/    /         \:::\  /:::/    /        \:::\    \                      /:::/    /    
     \:::\/:::/    /           \::::::/    /           \:::\/:::/    /          \:::\    \                    /:::/    /     
      \::::::/    /             \::::/    /             \::::::/    /            \:::\    \                  /:::/    /      
       \::::/    /               \::/____/               \::::/    /              \:::\____\                /:::/    /       
        \::/____/                 ~~                      \::/    /                \::/    /                \::/    /        
         ~~                                                \/____/                  \/____/                  \/____/         
                                                                                                                             
        ");

        Console.WriteLine(@"
  _                            _           _       
 | |__   ___ _ __ ___   __   _(_)_ __   __| | ___  
 | '_ \ / _ \ '_ ` _ \  \ \ / / | '_ \ / _` |/ _ \ 
 | |_) |  __/ | | | | |  \ V /| | | | | (_| | (_) |
 |_.__/ \___|_| |_| |_|   \_/ |_|_| |_|\__,_|\___/ 
                                                   
");
        Console.WriteLine("----------- REGRAS -----------\n \n - APERTE O NÚMERO 7 PARA FAZER PONTOS\n - DIGITE L PARA ACESSAR A LOJA\n - APERTE 9 PARA SAIR");
        Console.WriteLine("----------- MENU -----------\n \n L - LOJA\n 9 - SAIR\n\nContador de clicks:\n");
    }
}
