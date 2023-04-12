Menu();
static Vilao InvocarVilao()
{
    var EnderDragon = new Vilao("Ender Dragon", 1000, 10);
    var Vecna = new Vilao("Vecna", 1500, 25);
    var Slime = new Vilao("Slime", 50, 5);
    var Zombie = new Vilao("Zumbi", 500, 20);
    var VilaoAleatorio = new Random();
    int NovoChefe = VilaoAleatorio.Next(1, 5);
    switch (NovoChefe)
    {
        case 1: return EnderDragon;
        case 2: return Slime;
        case 3: return Vecna;
        case 4: return Zombie;
        default: InvocarVilao(); break; 
    }
    return InvocarVilao();
}

static void Movimento(double heroiPoderdeAtaque, double heroiVida, double vilaoPoderDeAtaque, double vilaoVida)
{
    Console.Clear();
    Console.WriteLine("Faça um movimento: ");
    Console.WriteLine("1-Atacar");
    Console.WriteLine("2-Esquivar");
    int opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1:
            Atacar(heroiPoderdeAtaque, heroiVida, vilaoPoderDeAtaque, vilaoVida);
            break;
        case 2:
            Esquivar(heroiPoderdeAtaque,heroiVida,vilaoPoderDeAtaque,vilaoVida);
            break;
        default:
            Movimento(heroiPoderdeAtaque,heroiVida,vilaoPoderDeAtaque,vilaoVida);
            break;
    }
    
}

static void Atacar(double heroiPoderDeAtaque, double heroiVida, double vilaoPoderDeAtaque, double vilaoVida)
{
    Console.WriteLine("Você atacou");
    vilaoVida -= heroiPoderDeAtaque;
    Console.WriteLine($"Atributos vilão: Vida = {vilaoVida}, PoderDeAtaque = {vilaoPoderDeAtaque}");
    if (vilaoVida <= 0)
    {
        Console.WriteLine("Você derrotou o vilão");
        Thread.Sleep(5000);
        Menu();
    }
    Thread.Sleep(2000);
    Console.WriteLine("O vilão atacou");
    heroiVida -= vilaoPoderDeAtaque;
    Console.WriteLine($"Seus atributos: Vida= {heroiVida}, PoderDeAtaque = {heroiPoderDeAtaque}");
    if (heroiVida <= 0)
    {
        Console.WriteLine("Voce morreu");
        Thread.Sleep(5000);
        Menu();
    }
    Thread.Sleep(2000);
    Movimento(heroiPoderDeAtaque,heroiVida,vilaoPoderDeAtaque,vilaoVida);

}

static void Esquivar(double heroiPoderDeAtaque, double heroiVida, double vilaoPoderDeAtaque, double vilaoVida)
{
    var numeroAle = new Random();
    var sorte = numeroAle.Next(1, 3);
    if (sorte == 1)
    {
        Console.WriteLine("O vilão atacou");
        Console.WriteLine("Voce se esquivou e conseguiu dar dano no vilão");
        heroiVida -= (vilaoPoderDeAtaque) / 2;
        vilaoVida -= (heroiPoderDeAtaque) / 5;
        Console.WriteLine($"Seus atributos: Vida = {heroiVida}, PoderDeAtaque = {heroiPoderDeAtaque}");
        Console.WriteLine($"Seus atributos: Vida = {vilaoVida}, PoderDeAtaque = {vilaoPoderDeAtaque}");
        if (vilaoVida <= 0) 
        {
            Console.WriteLine("Você derrotou o vilao");
            Thread.Sleep((2000));
            Menu();
            
        }
        if (heroiVida <= 0)
        {
            Console.WriteLine("Voce morreu");
            Thread.Sleep(3000);
            Menu();
        }
        Thread.Sleep(2000);
        Movimento(heroiPoderDeAtaque,heroiVida,vilaoPoderDeAtaque,vilaoVida);

    }

    if (sorte == 2)
    {
        Console.WriteLine("O vilao te atacou");
        Console.WriteLine("Você nao conseguiu esquivar do ataque do vilão");
        heroiVida -= vilaoPoderDeAtaque;
        Console.WriteLine($"Seus atributos: Vida = {heroiVida}, PodeDeAtaque = {heroiPoderDeAtaque}");
        if (heroiVida <= 0)
        {
            Console.WriteLine("Você morreu!");
            Thread.Sleep(3000);
            Menu();
        }
        Thread.Sleep(2000);
        Movimento(heroiPoderDeAtaque, heroiVida, vilaoPoderDeAtaque, vilaoVida);

    }
}
static void Batalha(Heroi heroi, Vilao vilao)
{
    Console.Clear();
    Console.WriteLine($"Atributos Heroi: Vida = {heroi.Vida}. PoderDeAtaque = {heroi.PoderDeAtaque}");
    Console.WriteLine($"Atributos Vilão: Vida = {vilao.Vida}, PoderDeAtaque = {vilao.PoderDeAtaque}");
    Console.WriteLine();
    Movimento(heroi.PoderDeAtaque, heroi.Vida,vilao.PoderDeAtaque,vilao.Vida);
    
}


static void StartGuerreiro()
{
    Console.Clear();
    var Guerreiro = new Heroi("Guerreiro",1000,10);
    var vilao = InvocarVilao();
    Console.WriteLine("Você escolheu a classe: Guerreiro");
    Console.WriteLine($"Seus atributos: Vida = {Guerreiro.Vida}, PoderDeAtaque = {Guerreiro.PoderDeAtaque}");
    Thread.Sleep(2000);
    Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
    Console.WriteLine($"Atributos do vilão: Vida = {vilao.Vida}, PoderDeAtaque = {vilao.PoderDeAtaque}");
    Thread.Sleep(5000);
    //Inicio da batalha
    Batalha(Guerreiro, vilao);

}

static void StartArqueiro()
{
    Console.Clear();
    var Arqueiro = new Heroi("Arqueiro", 600, 100);
    var vilao = InvocarVilao();
    Console.WriteLine("Você escolheu a classe: Arqueiro");
    Console.WriteLine($"Seus atributos: Vida = {Arqueiro.Vida}, PoderDeAtaque = {Arqueiro.PoderDeAtaque}");
    Thread.Sleep(2000);
    Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
    Console.WriteLine($"Atributos do vilão: Vida = {vilao.Vida}, PoderDeAtaque = {vilao.PoderDeAtaque}");
    Thread.Sleep(5000);
    //Inicio da batalha
    Batalha(Arqueiro, vilao);
}

static void StartAssassino()
{
    Console.Clear();
    var Assassino = new Heroi("Assassino", 500, 150);
    var vilao = InvocarVilao();
    Console.WriteLine("Você escolheu a classe: Assassino");
    Console.WriteLine($"Seus atributos: Vida = {Assassino.Vida}, PoderDeAtaque = {Assassino.PoderDeAtaque}");
    Thread.Sleep(2000);
    Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
    Console.WriteLine($"Atributos do vilão: Vida = {vilao.Vida}, PoderDeAtaque = {vilao.PoderDeAtaque}");
    Thread.Sleep(5000);
    //Inicio da batalha
    Batalha(Assassino, vilao);
    
}
static void StartMago()
{
    Console.Clear();
    var Mago = new Heroi("Assassino", 500, 150);
    var vilao = InvocarVilao();
    Console.WriteLine("Você escolheu a classe: Assassino");
    Console.WriteLine($"Seus atributos: Vida = {Mago.Vida}, PoderDeAtaque = {Mago.PoderDeAtaque}");
    Thread.Sleep(2000);
    Console.WriteLine($"O vilão {vilao.Nome} apareceu!");
    Console.WriteLine($"Atributos do vilão: Vida = {vilao.Vida}, PoderDeAtaque = {vilao.PoderDeAtaque}");
    Thread.Sleep(5000);
    //Inicio da batalha
    Batalha(Mago, vilao);
    
}

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao RPG");
    Console.WriteLine("Escolha sua classe");
    Console.WriteLine("1-------Guerreiro---------");
    Console.WriteLine("2-------Arqueiro----------");
    Console.WriteLine("3-------Assassino---------");
    Console.WriteLine("4-------Mago--------------");
    Console.WriteLine("5-------Exit--------------");
    Console.WriteLine(" ");
    Console.WriteLine("Selecione uma opção: ");
    short res = short.Parse(Console.ReadLine());
    switch (res){   
        case 1:StartGuerreiro(); break;
        case 2:StartArqueiro();break;
        case 3:StartAssassino();break;
        case 4:StartMago();break;
        case 5:System.Environment.Exit(0);break;
        default: Menu();break;

    }
}
public struct Heroi
{
    public Heroi(string classe, double vida, double poderDeAtaque)
    {
        Classe = classe;
        Vida = vida;
        PoderDeAtaque = poderDeAtaque;
    }

    public string Classe { get; set; }
    public double Vida { get; set; }
    public double PoderDeAtaque { get; set; }
}

public struct Vilao
{
    public Vilao(string nome, double vida, double poderdeataque)
    {
        Nome = nome;
        Vida = vida;
        PoderDeAtaque = poderdeataque;
        

    }
    public string Nome { get; set; }
    public double Vida { get; set; }
    public double PoderDeAtaque { get; set; }
}



