using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjackvs2
{
    class Blackjackvs
    {
        public static void Main(String[] args)
        {
            main.start();
        }
    }




    class judge
    {
        public static void admin(int money1, int money)
        {
            result result = Fight();
            client1 client = new client1();
            client2 client2 = new client2();
            Action action = judge.GetAction(client);

            Action action2 = judge.GetAction(client2);

            if (result.player1swin == result)
            {
                if (Action.raze == action)
                {
                    Console.WriteLine(money1 + "raze:x2\n" + money1 * 2);
                    money1 *= 2;
                }
                if (Action.forld == action)
                {
                    Console.WriteLine(money1 + "forld:\n" + money1);
                }
                if (Action.bet == action)
                {
                    Console.WriteLine(money1 + "bet\n" + money1 + money1);
                    money1 += money1;
                }
            }

            else if (result.player2swin == result)
            {
                if (Action.raze == action)
                {
                    Console.WriteLine(money1 + "raze:-x2\n" + money1 * 2);
                    money1 -= money1 * 2;
                }
                if (Action.forld == action)
                {
                    Console.WriteLine(money1 + "forld:\n" + money1);
                }
                if (Action.bet == action)
                {
                    Console.WriteLine(money1 + "bet\n" + money1 + money1);
                    money1 -= money1;
                }

            }
            else if (result.dealerswin == result)
            {
                if (Action.raze == action)
                {
                    Console.WriteLine(money1 + "raze:-x2\n" + money1 * 2);
                    money1 -= money1 * 2;
                }
                if (Action.forld == action)
                {
                    Console.WriteLine(money1 + "forld:\n" + money1);
                }
                if (Action.bet == action)
                {
                    Console.WriteLine(money1 + "bet\n" + money1 + money1);
                    money1 -= money1;
                }

            }
            else if (result.draw == result)
            {
                if (Action.raze == action)
                {
                    Console.WriteLine(money1 + "raze:x2\n" + (money1 * 2) / 2);
                    money1 -= (money1 * 2) / 2;
                }
                if (Action.forld == action)
                {
                    Console.WriteLine(money1 + "forld:\n" + money1);
                }
                if (Action.bet == action)
                {
                    Console.WriteLine(money1 + "bet\n" + money1 + money1 / 2);
                    money1 += money1 / 2;
                }
            }
            Console.WriteLine(money1);
            client1.playerpoint += money1;

            if (result.player2swin == result)
            {
                if (Action.raze == action2)
                {
                    Console.WriteLine(money + "raze:x2\n" + money * 2);
                    money *= 2;
                }
                if (Action.forld == action2)
                {
                    Console.WriteLine(money + "forld:\n" + money);
                }
                if (Action.bet == action2)
                {
                    Console.WriteLine(money + "bet\n" + money + money);
                    money += money;
                }
            }

            else if (result.dealerswin == result)
            {
                if (Action.raze == action2)
                {
                    Console.WriteLine(money + "raze:-x2\n" + money * 2);
                    money -= money * 2;
                }
                if (Action.forld == action2)
                {
                    Console.WriteLine(money + "forld:\n" + money);
                }
                if (Action.bet == action2)
                {
                    Console.WriteLine(money + "bet\n" + money + money);
                    money -= money;
                }

            }
            else if (result.player1swin == result)
            {
                if (Action.raze == action2)
                {
                    Console.WriteLine(money + "raze:-x2\n" + money * 2);
                    money -= money * 2;
                }
                if (Action.forld == action2)
                {
                    Console.WriteLine(money + "forld:\n" + money);
                }
                if (Action.bet == action2)
                {
                    Console.WriteLine(money + "bet\n" + money + money);
                    money -= money;
                }

            }
            else if (result.draw == result)
            {
                if (Action.raze == action2)
                {
                    Console.WriteLine(money + "raze:x2\n" + (money * 2) / 2);
                    money -= (money * 2) / 2;
                }
                if (Action.forld == action2)
                {
                    Console.WriteLine(money + "forld:\n" + money);
                }
                if (Action.bet == action2)
                {
                    Console.WriteLine(money + "bet\n" + money + money / 2);
                    money += money / 2;
                }
            }

            Console.WriteLine(money);
            client2.player2spoint += money;
        }

        private static result Fight()
        {
            judge judge = new judge();
            Deck deck = new Deck();
            deck.queue = deck.cardsSuffle(deck);
            while (client1.player1sflag || dealer.dealersflag || client2.player2sflag)
            {
                if (client1.player1sflag)
                {
                    client1.player1turn(deck.queue.Dequeue());
                }
                if (client2.player2sflag)
                {
                    client2.player2turn(deck.queue.Dequeue());
                }
                if (dealer.dealersflag)
                {
                    dealer.dealersturn(deck.queue.Dequeue());
                }
            }
            return Account();

        }
        public static result Account()
        {
            if (client1.player1cardpoint <= 21 && dealer.dealerscard <= 21 && client2.player2cardpoint <= 21)
            {
                if (client2.player2cardpoint <= client1.player1cardpoint) {
                    if (client1.player1cardpoint <= dealer.dealerscard)
                    {
                        Console.WriteLine("ディーラーの合計");
                        Console.WriteLine(dealer.dealerscard);
                        Console.WriteLine("プレイヤー１の合計");
                        Console.WriteLine(client1.player1cardpoint);
                        Console.WriteLine("プレイヤー２の合計");
                        Console.WriteLine(client2.player2cardpoint);
                        Console.WriteLine("ディーラーの勝ちです...");
                        return result.dealerswin;
                    }
                }
                if (client2.player2cardpoint <= dealer.dealerscard)
                {
                    if (client1.player1cardpoint >= dealer.dealerscard)
                    {
                        Console.WriteLine("プレイヤー１の合計");
                        Console.WriteLine(client1.player1cardpoint);
                        Console.WriteLine("ディーラーの合計");
                        Console.WriteLine(dealer.dealerscard);
                        Console.WriteLine("プレイヤー２の合計");
                        Console.WriteLine(client2.player2cardpoint);
                        Console.WriteLine("プレイヤー１の勝ちです！");
                        return result.player1swin;
                    }

                }
                if (client1.player1cardpoint >= dealer.dealerscard)
                {
                    if (client1.player1cardpoint <= client2.player2cardpoint)
                    {
                        Console.WriteLine("プレイヤー１の合計");
                        Console.WriteLine(client1.player1cardpoint);
                        Console.WriteLine("ディーラーの合計");
                        Console.WriteLine(dealer.dealerscard);
                        Console.WriteLine("プレイヤー２の合計");
                        Console.WriteLine(client2.player2cardpoint);
                        Console.WriteLine("プレイヤー２の勝ちです！");
                        return result.player2swin;

                    }
                }

            }
            else if (client1.player1cardpoint > 21 || dealer.dealerscard > 21 || client2.player2cardpoint > 21)
            {
                if (client1.player1cardpoint >= 21)
                {
                } else if (dealer.dealerscard >= 21)
                {
                    Console.WriteLine("バースト！");
                    Console.WriteLine("プレイヤー２の勝ちです！");
                    return result.player2swin;

                } else if (dealer.dealerscard <= 21)
                {
                    if (dealer.dealerscard <= client2.player2cardpoint)
                    {
                        Console.WriteLine("バースト！");
                        Console.WriteLine("プレイヤー２の勝ちです！");
                        return result.player2swin;

                    } else
                    {
                        Console.WriteLine("バースト！");
                        Console.WriteLine("ディーラーの勝ちです！");
                        return result.dealerswin;
                    }
                }
                if (client2.player2cardpoint >= 21)
                {
                }
                else if (client1.player1cardpoint >= 21)
                {
                    Console.WriteLine("バースト！");
                    Console.WriteLine("ディーラーの勝ちです！");
                    return result.dealerswin;

                }
                else if (client1.player1cardpoint <= 21)
                {
                    if (client1.player1cardpoint <= dealer.dealerscard)
                    {
                        Console.WriteLine("バースト！");
                        Console.WriteLine("ディーラーの勝ちです！");
                        return result.dealerswin;

                    }
                    else
                    {
                        Console.WriteLine("バースト！");
                        Console.WriteLine("プレイヤー１の勝ちです！");
                        return result.player1swin;
                    }
                }


                if (dealer.dealerscard >= 21)
                {
                }
                else if (client2.player2cardpoint >= 21)
                {
                    Console.WriteLine("バースト！");
                    Console.WriteLine("プレイヤー１の勝ちです！");
                    return result.player1swin;

                }
                else if (client2.player2cardpoint <= 21)
                {
                    if (client1.player1cardpoint <= client2.player2cardpoint)
                    {
                        Console.WriteLine("バースト！");
                        Console.WriteLine("プレイヤー２の勝ちです！");
                        return result.player2swin;

                    }
                    else
                    {
                        Console.WriteLine("バースト！");
                        Console.WriteLine("プレイヤーの勝ちです！");
                        return result.player1swin;
                    }
                }
            }
            if(client1.player1cardpoint == 21 && client2.player2cardpoint == 21 && dealer.dealerscard == 21)
            {
                Console.WriteLine("引き分け");
                return result.draw;
            }


            return result.draw;

        }
            
        


        private static Action GetAction(client1 client)
        {
            return client1.actionpointer;
        }
        private static Action GetAction(client2 client2)
        {
            return client2.actionpointer2;
        }

    }

    enum result
    {
        player1swin,
        player2swin,
        dealerswin,
        draw

    }


    
    public class client1
    {

        public static String name1 = "プレイヤー１";
        public static int playerpoint = 100;
        public static int player1cardpoint;
        public static bool player1sflag = true;
        public static Action actionpointer;
        static bool firstmatch1 = true;

        public static void player1turn(Card card)
        {

            if (firstmatch1)
            {
                Console.WriteLine(name1 + "アクション? 賭けに属性を付けれます。\nraze:期待値二倍。しかし負けると負債も二倍\nforld:何もかけない。引かないと同じ？これがどのような効果を出すかは分からない。\nbet:通常。");

                switch (Console.ReadLine())
                {
                    case "raze":
                        {
                            actionpointer = Action.raze;
                        }
                        break;
                    case "forld":
                        {
                            actionpointer = Action.forld;
                        }
                        break;
                    case "bet":
                        {
                            actionpointer = Action.bet;
                        }
                        break;
                }
            }
            firstmatch1 = false;


            Console.WriteLine(name1 + "引く 引かない");
            String str = Console.ReadLine();
            if (str.Equals("引く"))
            {
                Console.WriteLine("プレイヤー"+card.markpointer + "の" + card.numpointer + "を引いた！");
                player1cardpoint += card.pointpointer;
                Console.WriteLine("プレイヤー合計" + player1cardpoint);
                Console.WriteLine("ディーラー合計" + dealer.dealerscard);
                Console.WriteLine("プレイヤー２合計" + client2.player2cardpoint);
            }
            else if (str.Equals("引かない"))
            {
                Console.WriteLine("スタンド");
                player1sflag = false;
                Console.WriteLine("プレイヤー1合計" + player1cardpoint);
            }

        }

    }
    public class client2
    {
        public static String name2 = "プレイヤー２";
        public static int player2spoint = 100;
        public static int player2cardpoint;
        public static bool player2sflag = true;
        public static Action actionpointer2;
        static bool firstmatch = true;

        public static void player2turn(Card card)
        {

            if (firstmatch)
            {
                Console.WriteLine(name2 + "アクション? 賭けに属性を付けれます。\nraze:期待値二倍。しかし負けると負債も二倍\nforld:何もかけない。引かないと同じ？これがどのような効果を出すかは分からない。\nbet:通常。");

                switch (Console.ReadLine())
                {
                    case "raze":
                        {
                            actionpointer2 = Action.raze;
                        }
                        break;
                    case "forld":
                        {
                            actionpointer2 = Action.forld;
                        }
                        break;
                    case "bet":
                        {
                            actionpointer2 = Action.bet;
                        }
                        break;
                }
            }
            firstmatch = false;


            Console.WriteLine(name2 + "引く 引かない");
            String str = Console.ReadLine();
            if (str.Equals("引く"))
            {
                Console.WriteLine("プレイヤー２"+card.markpointer + "の" + card.numpointer + "を引いた！");
                player2cardpoint += card.pointpointer;
                Console.WriteLine("プレイヤー合計" + client1.player1cardpoint);
                Console.WriteLine("ディーラー合計" + dealer.dealerscard);
                Console.WriteLine("プレイヤー２合計" + client2.player2cardpoint);
            }
            else if (str.Equals("引かない"))
            {
                Console.WriteLine("スタンド");
                player2sflag = false;
                Console.WriteLine(name2+"合計" + player2cardpoint);
            }

        }

    }
    class dealer
    {
        public static String name3 = "ディーラー";
        public static int dealerscard;
        public static bool dealersflag = true;
        public static void dealersturn(Card card)
        {
            if (16 < dealerscard)
            {
                Console.WriteLine("ディーラーが引かない");
                dealersflag = false;
                Console.WriteLine("ディーラー合計" + dealerscard);
            }
            else if (16 > dealerscard)
            {
                Console.WriteLine("ディーラーは"+card.markpointer + "の" + card.numpointer + "を" + "引いた");
                dealerscard += card.pointpointer;
                Console.WriteLine("ディーラー合計" + dealerscard);

            }
        }
    }
    
    public enum Action
    {
        raze,
        forld,
        bet
    }

   public class Card
    {
        public String[] num = new string[14];
        public String[] Mark = new string[4];

        public int[] points = new int[14];

        public String numpointer;

        public String markpointer;

        public int pointpointer;



        private Card cardpointer;


        public Card()
        {
            for (int i = 1; i <= 13; i++)
            {
                num[i] = i.ToString();
            }

            Mark[0] = "スペード";
            Mark[1] = "ダイヤ";
            Mark[2] = "ハート";
            Mark[3] = "クラブ";

            for (int i = 1; i <= 13; i++)
            {
                points[i] = i;
            }
        }

        public Card(String num, String mark, int point)
        {
            numpointer = num;

            markpointer = mark;

            pointpointer = point;
        }

        public Card clcard(String num, String mark, int point)
        {

            cardpointer = new Card(num, mark, point);

            return cardpointer;
        }

    }

    class Deck
    {
        public Queue<Card> queue = new Queue<Card>();

        public Deck()
        {
            Card card = new Card();

            for (int i = 1; i <= 13; i++)
            {
                queue.Enqueue(card.clcard(card.num[i], card.Mark[0], card.points[i]));
            }
            for (int i = 1; i <= 13; i++)
            {
                queue.Enqueue(card.clcard(card.num[i], card.Mark[1], card.points[i]));
            }
            for (int i = 1; i <= 13; i++)
            {
                queue.Enqueue(card.clcard(card.num[i], card.Mark[2], card.points[i]));
            }
            for (int i = 1; i <= 13; i++)
            {
                queue.Enqueue(card.clcard(card.num[i], card.Mark[3], card.points[i]));
            }
        }
        public Queue<Card> cardsSuffle(Deck deck)
        {

            Card[] cards = deck.queue.ToArray();
            Random rand = new Random();
            int n = cards.GetLength(0);
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }

            Queue<Card> queue = new Queue<Card>(cards);

            return queue;


        }

    }
    class main
    {
        public static void start()
        {

            string text;
            string text2;
            do
            {
                Console.WriteLine("準備OK?\n双方の準備が完了したらディーラーがカードを配ります\nコマンド:y");
                text = Console.ReadLine();

                text2 = Console.ReadLine();
                if (text.Equals("y") && text2.Equals("y"))
                {
                    if (client1.playerpoint > 0 && client2.player2spoint > 0)
                    {
                        Console.WriteLine("プレイヤー１のコイン" + client1.playerpoint + "プレイヤー２のコイン" + client2.player2spoint + "ベットする金額を決めてください。1 - 100");

                        int point = Convert.ToInt32(Console.ReadLine());
                        int point2 = Convert.ToInt32(Console.ReadLine());
                        if (point <= 100 && client1.playerpoint >= point && point2 <= 100 && client2.player2spoint >= point)
                        {
                            client1.playerpoint -= point;

                            client2.player2spoint -= point2;

                            judge.admin(point, point2);


                        }
                        else if (point > 100 && client1.playerpoint <= point && point2 > 100 && client2.player2spoint <= point)
                        {
                            Console.WriteLine("その数はベットできません。");
                        }
                    }
                }

            }
            while (text.Equals("y") || text2.Equals("y"));





        }

    }
}

