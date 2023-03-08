using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Aplicatie
{
    public partial class Form4 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );
        int all = 0;
        int m = 1;
        public Form4()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(475, 150);

            next_pict.BackgroundImage = Properties.Resources.rightarrow;
            prev_pict.BackgroundImage = Properties.Resources.Larrow;


            pictureBox1.BackgroundImage = Properties.Resources.remove__1;
          
            pictureBox1.MouseEnter += OnMouseEnterX;
            pictureBox1.MouseLeave += OnMouseLeaveX;
            prev_pict.MouseEnter += OnMouseEnterprev; prev_pict.MouseLeave += OnMouseLeaveprev;
            prev1.MouseEnter += OnMouseEnterprev; prev1.MouseLeave += OnMouseLeaveprev;



            next_pict.MouseEnter += OnMouseEnternext; next_pict.MouseLeave += OnMouseLeavenext;
            next1.MouseEnter += OnMouseEnternext; next1.MouseLeave += OnMouseLeavenext;
            next2.MouseEnter += OnMouseEnternext; next2.MouseLeave += OnMouseLeavenext;

            explica.Visible = false;

            next1.Cursor = next2.Cursor = prev1.Cursor = prev_pict.Cursor = next_pict.Cursor = explicatie.Cursor = pictureBox1.Cursor = Cursors.Hand;

            m = 1; navigare();
        }
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }




        void texte()
        {

            if (all == 0)
            {
                next1.Visible = false;

            }
            else if (all == 1)
            {
                next1.Visible = true;

            }

            if (m == 1)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  In anul 1859, doctorul italian Paolo Mantegazza a facut o calatorie in Peru, unde a descoperit utulizarile frunzelor de coca de catre localnici. El a incercat sa experimenteze pe el, iar cand s-a intors la Milano,a declarat ca frunzele de coca si caina au efecte medicinale." + Environment.NewLine + "  La procesul de creeare a bautruii,au chimistul Angeli Maruani care a citit notitele lui Mabtegazza a inceput sa fie interesat de potentialul economic. In 1863,Mariani a inceput sa comercializeze un vin denumit „Vin Mariani” ce continea frunze de coca.In 18886, Styh Pembertin a conceput retata a ceea ce avea sa devina cea mai cunoscuta bautura din lume- Coca-Cola." + Environment.NewLine + "Pana la Legea privind alimentele și drogurile pure din 1906 , in fabricarea bauturii s-au folosit frunze de coca- de aici si denumirea de „Coca”. Totusi, bautura a fost privita drept un medicament pentru dureri de cap, indispozitie generala, oboseala etc.";

                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 4)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  Lupta pentru Africa a inceput odata cu Conferinta de la Berlin (1884-1885) si s-a sfarsit la inceputul secolului 20. In aceasta perioada, colonizatorii europeni au partitionat Africa in sfere de influnta, colonii si diverse segmente, chiar daca cunostintele geografice,istorice, colturale, si etnice ale continentului erau limitate. Comunitatile tarilor precum Ethiopia, Sudan, Kenya , Somalia (care a fost impartita intre Italia, Marea Briatanie si Franta) au fost separate , iar activitatile lor de zi cu zi (pastoritul si obiceiurile) au fost grav afectate.";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 6)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = " Razboiul Ruso-Japonez a fost purtat intre 1904 si 1905, iar amibtiile imperiale rivale asupra Manciurei si Coreei erau mari. Rusia dorea de mult un port la oceanul cu apa calda pentru flota navala si comert. Vazand in Rusia un temtut arversar, Japonia a oferit controclul asupra Manciuriei in schimbul recunoasterii Coreei ca fiind parte din sfera da influenta japoneza. " + Environment.NewLine + " Rusia a refuzat, iar Japonia a purtat un atac surpriza la Portul Arthur. Razboiul s-a sfarsit cu Tratatyk de ka Portsmouth, mediat de presedintele Theodor Rooselvelt, iar vicotria Japoniei a surprins intraga lume. ";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 11)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  Cunoscut drept Armistitiul de Craciun, acesta a presupus incetarea focurilor pe anumite portiuni de transee. In anul primul an de razboi, soldatii, plecati de acasa cu baionete si pusti, fara sa stie daca se vor mai intoarce, au inceput sa fie emotionati de obieciurile de Craciun." + Environment.NewLine + "  Au inceput sa cante colinde, si usor usor, de dragul feeriei Craciunului , au ajuns sa iasa din transee pentru a sarbatori Craciunul . Britanicii si nemtii au fost fotgrafiati oferind ciocolata si tigari, jucand fotbal sau cantand coline. In unele portiuni, bucuria Craciunului a durat pana de Anul Nou.";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 12)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = " Printre mitraliera, grenada de mana , lansatorul de flacari si tancul , gasul cu clor a fost una dintre acele inventii care a schimbat cursul razboiului. Acesta a fost folosit pentru prima data de germani impotriva britanicilor si canadienilor care lupatau langa Yperes(Belgia) in 1917. Aliatii au ajuns sa foloseasca si ei aceasta arma(inventata de Fritz Haber) in timpul bataliei de la Cambrai, dupa ce au capturat un inventar de astfel de armament." + Environment.NewLine + "  Gasul cu clor este toxic, dispersat ca un aerosol, de culoarea galbuie, a carui efecte persista tin saptamani intregi." + Environment.NewLine + "  O simpla masca de gaze era de prisos, de vreme ce hainele soldatului se contaminau la fel de repede pe cat se raspandeste gazul.";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 16)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  In februarie 1915,Winston Churhcill a creeat Comitetul Teritorial cu scopul de a proiecta un vehicul care sa transporte trupe. Folosindu-se de niste idei deja existente (in 1914 Ernest Swinton a prezentat design-ul unui tractor cu tun, dar a fost considerat nebun)." + Environment.NewLine + "Primele tancuri din istorie- Mark I- au fost puse pe campul de lupta pe data de 15 septembire 1916, in timpul bataliei de l Somme.Dintre cele 49 de tancuri,doar 32 a luat parte la lupta propriu-zisa, iar 9 dintre ele au trecut de „teritriul nimanui”, penetrand liniile germane.  ";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 17)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = " Pe data de 1 februarie 1917, trtatul submarinelor nemtesti U-boat a fost ridicat din nou, de vreme  ce Germania s-a intors la politica de războiul submarin fără restricții. Acest tip de razboi a fost introdus pentru prima data in 1915, cand Germania a inceput sa atace orice nava britanica, fie si ea comerciala." + Environment.NewLine + "  Dupa o actiune necugetata, in care a fost scufundat un vas cu 1201 de pasageri, dintre care 128 americanii, presedintele american Woodrow Wilson a cerut Germaniei sa sfarseasca aceste atacuri." + Environment.NewLine + " Guvernul a inceput sa pune restrictii, dar comandantii de nave nu au fost de acord cu aceasta decizie. Kaiserul a organizat o intalnire cu leaderii maritimi care s-au aratat reticeenti in privinta restrictiilor razboiul cu submarine.";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 18)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  Dupa perioada interbelica, Germania a avut de suferit de pe urma Tratatului de la Versailles care a impus nenumarate masuri menite sa previna izbucnirea unui nou razboi mondial." + Environment.NewLine + "  Germania a pierdut coloniile din Africa, alea putine pe care le avea, iar Aliatii au cufundat-o in datorii pentru a se asigura ca Germania nu va mai avea niciodata posibilatea sa porneasca un nou razboi. Economia de piata nu a facut fata datoriilor, francezii au ocupat echipament industrial din teritoriul Rurh, iar ,pentru a plati muncitorii, guvernul a printat mai multi bani. " + Environment.NewLine + "  Preturile au inceput sa creasca incotrolabil. In aceea perioada, daca o persoana venea cu o raoba de bani sa cumpere o casa, nu i s-ar fi furat banii, ci roaba." + Environment.NewLine + "  S.U.A. au intrat si ele in criza economica pentru ca s-au oferit sa acorde imprumuturi Germaniei.";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 21)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  Penicilina este un membru dintr-o grupa de antibitotice folosite pe scara larga pentru a trata infectiile bacteriene, precum tuberculoza, pneumonia sua febra reumatica. " + Environment.NewLine + "  In mod surprinzator, acest medicament a aparut „printr-un” miracol. Dupa ce Alexander Fleming s-a intors dintr-un concediu, acesta a gasit in prorpiul laborator vase ce contineau bacterii stafilococice si notatum de penicilium, ce opreste dezvoltarea bacteriilor. Fleming a reusit sa obtina un extract pe care l-a denumit ulterior „penicilina”." + Environment.NewLine + "  „Când m-am trezit chiar după zorii zilei de 28 septembrie 1928, cu siguranță nu intenționam să revoluționez toate medicamentele descoperind primul antibiotic din lume sau cel care ucide bacteriile.”-Alexander Fleming";

                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 25)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  Inca din perioda interbelica, caracterizata de o populatie demoralizata dupa o infrangere rusinoasa, produse farmceutice menite sa alunge suferinta nu au lipsit de pe rafturile Germaniei, care ,dupa ce a pierdut coloniile din Africa, alea putine pe care le avea, a pierdut si acces la ceai si cafea." + Environment.NewLine + "  Astfel, tara s-a vazut nevoita sa gaseasca un substituient sintetic menit sa ofere energie consumatorului. Asa a aparut „Pervitinul”-acesta continea metamfetamina si era consumat la scara larga." + Environment.NewLine + "  Armata a profitat din plin de pe urma puterilor acestui medicament minune, care a alungat oboseala soldatilor." + Environment.NewLine + " „V-am cerut sa nu dormiti 48 de ore.Ati reusit sa rezistati 17 zile”-Henz Guderian";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 29)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  In timpul Razboiul Blitzkrieg, Luftwaffe coordonau ataucuri de obicei pe timp de noapte. Royal Air Force aveau la dispozitie un sistem secret de radare ce le permitea britanicilor sa incercepteze avionale nemtesti atunci cand treceau de Canalul Manecii." + Environment.NewLine + "  Primul pilot care a doborat un avion german folosind aceasta tehnologie este Jhon Cunningham - „Ochiul Piscii”- care a relatat ca precizia sa se datoreaza cantitatilor mari de morcovi." + Environment.NewLine + "  Datorita lipsei de alimente din Marea Britanie, guvernul s-a vazut nevoit sa rationalizeze toate alimentele, din lipsa de zahar,sunca si unt." + Environment.NewLine + "   „Dr. Carrot” si „Poato Pete” erau desene animate ce au fost lansate pentru a incuraja oamenii sa manance legume. " + Environment.NewLine + "„Broșura 4 a Bucătăriei de ăzboi” a Ministerului a fost umplută cu rețete cu tort de morcovi, budincă de morcovi, marmeladă de morcovi și flan de morcovi.";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 34)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = " Initial, 1930 caini au inceput sa fie folositi pe post de arma anti-tanc." + Environment.NewLine + "  Initial,acestia au fost dresati sa puna bomba langa tanc ca mai apoi sa fie detonata de la o distanta sigura, dar,cainii, debusolati, se intorceau cu bomba in spate." + Environment.NewLine + "  Ideea a fost un esec, dar sovietici au venit cu alta. In loc sa lase bomba langa tanc, inginerii au proiectat o bomba care se auto-detona in momentul in care cainele intra sub tanc. Pentru a-i dresa, aramta URSS infometa cainii ca apoi sa le puna mancare sub tanc ca sa ii determine sa activeze explovibili." + Environment.NewLine + "  In 1941, cand au fost introdusi caini ce transportau bombe, in incercarea de a distruge vehiculele nemtesti, incercare ce a fost atata de ineficienta, incat armata sovietica a fost acuzata ca a sacrificat animalele pentru nimic, ba unii caini au intrat fix sub tancurile sovietice (tancuri cu care au fost antrenati).";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 35)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  Neutralitatea Elvetiei in cele doua razboaie mondiale i-a oferit Germaniei oportunitatea de a-si depozita aurulul." + Environment.NewLine + "  Elvetia, renumita pentru banci, ciocolata si biciclete, are si o parte intunecata cand vine vorba de afacerile bancare. Actul Bancar din 1934, ce oferea anonimitatea clientilor. Htiler s-a deciz sa depoziteze in banci elvetiene aurul furat de la evreii din tarile pe care le ocupase." + Environment.NewLine + "  Ba chiar companii precum Nestle, au ignorat atrocitatile facute de nazisti pentru a-si vinde produsele.";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 36)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = " Dupa pactul Ribbentrop-Molotov-semnat intre ministrul de externe german Ribbentrop si omolgoul sau sovietic Molotov- ce impartea Europa in sfere de influenta, Stalin era totusi nemultumit de pozitia Finlandei,revoltator de ostila pentru orasul Leningrad." + Environment.NewLine + "  URSS a inceput un razboi cu Finlanda (1939-1940), armata sovietica nu era pregatita pentru terenul din aceea zona. Finlandezii au purtat un razboi de gherila, folosindu-se de propriul teren pentru a-i alunga pe rusi." + Environment.NewLine + "  Acestia erau camuflati, aveau echipament calduros si erau de multa ori vazuti cu schiuri si cu automatul in mana. Pentru a orpi tancurile, finlandezii foloseau lemne pentru a le bloca senilele, ca mai apoi sa le arda folosind cocktail- uri Molotov. ";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 37)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  In anul 1940-anul anexarilor teritoriale- Hitler a reusit sa puna mana pe Franta, Olanda, Norvegia si Danemarca." + Environment.NewLine + "  Danemarca a avut o importanta limitata, aceasta fiind folosita ca un ajotur pentru viitoarele operatiuni in Norvegia. O retea scumpa de sisteme radar a fost construita in Danemarca pentru a detecta avioanele britanice Royal AirForce." + Environment.NewLine + "  Dupa mai putin de doua ore de lupta, prim-ministrul danez Thorval Stauning a incetat sa arate opozitie armatei germane, de teama ca capitala va fi bombardata. Din cauza unor dificultati de comunicare, unele trupe daneze au continuat lupta." + Environment.NewLine + "  Dupa doar sase ore, Hitler a dobandit controlul asupra Danemarcei.";
                }
                else if (all == 1)
                {
                    explica.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 43)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  In ultimii ani de viata, liderul sovietic Iosef Stalin - cel care pe data de 15 aprilie 1919 a introdus Gulagul- a inceput sa devine paranoic. Reprezentantilor sovietici din strainatate pe care ii doar ii banuia ca simpatizeaza cu capitalismul le oferea „o vacanta in Rusia, pentru a vizita Piata Rosie din Moscova si Sankt Petersburg” ,cand le oferea o vacanta in Siberia" + Environment.NewLine + "  In 1950, a timis in Gulag pe medicii pe care ii suspecta ca ii vor raul. Trist este ca in 1953, a suferit un atac cerebral in propria camera. Soldatii care pazeau camera s-au sfiit sa il verifice, de teama ca vor fi executati. A doua zi , o camerista/paznic l-au gasit pe Stalin intins pe podea." + Environment.NewLine + "  KGB-ul a cules de pe strazile Moscovei pe medicii care au supravietuit paranoiei lui Stalin. Tuturor le era teama sa il atinga.";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 44)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explicatie.Text = "Am inteles!";
                    descriere.Text = "  Inainte ca oamenii sa mearga in spatiu, animalele au fost folosite pentru a teste rachetele. Laika este cel mai cunoscut animal care a ajuns pe orbita Pamantului, dar maimutele au fost cele pe care s-au facut cele mai multe experimente." + Environment.NewLine + "  Pe data de 28 mai 1959, Able(macac) si Domnisoara Maker(maimuta) au fost primele animale care au pornit intr-o calatorie spatiala." + Environment.NewLine + "  Ham (cel pe care il vedeti in imagine) si Sam au zburat in cadrul programului Mercury. Ei erau chimpanzei,iar denumirire lor sunt acronime." + Environment.NewLine + "  In total, 32 de maimute au zburat in cadrul proiectului spatial, dintre care 9 dintre ele s-au bucarat de 2 calatori in timpul vietii. Multe dintre ele au murit/au fost ranite in timpul zborului, dar de obicei, in timpul recupararilor medicale. ";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }
            else if (m == 49)
            {
                if (all == 0)
                {
                    descriere.Visible = true; explica.Text = "Am inteles!";
                    descriere.Text = "  Razboaiele iugoslave au fost o serie de conflicte purtate in Iugoslavia intre 1991 sin 2001, care au dus la faramitarea Iugoslaviei. Republicile si-au declarat independenta, dar au lasat loc unor tensiuni de durata." + Environment.NewLine + "  Deseori descrise drept cele mai sangeroase conflicte de dupa Al Doilea Razboi Mondial, acestea au fost conturate de crime de razboi, printre care si genocidul, crime impotriva umanitatii. Genocidul bosniac a fost primul care a fost clasificat oficial drept genocid de dupa WWII." + Environment.NewLine + "  Se estimeaza ca aproape 140,000 de oameni si-au pierdut viata in cadrul razboaielor iugoslave, iar conditiile de viata erau asamanatoare Somaliei.";
                }
                else if (all == 1)
                {
                    explicatie.Text = "Explică!"; descriere.Visible = false;
                }
            }

        }

        void navigare()
        {
            descriere1.Visible = false;
            next2.Visible = next_pict.Visible = prev1.Visible = prev_pict.Visible = true;
            explicatie.Visible = descriere.Visible = false;
            if (m == 1)
            {
                prev1.Visible = prev_pict.Visible = false;
                
                nr.Text = "#1";
                poza.BackgroundImage = Properties.Resources.ar1;

                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 2)
            {
                nr.Text = "#2";
                poza.BackgroundImage = Properties.Resources.ar2;
            }
            else if (m == 3)
            {
                nr.Text = "#3";
                poza.BackgroundImage = Properties.Resources.ar3;
            }
            else if (m == 4)
            {
                nr.Text = "#4";
                poza.BackgroundImage = Properties.Resources.ar4;

                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 5)
            {
                nr.Text = "#5";
                poza.BackgroundImage = Properties.Resources.ar5;
            }
            else if (m == 6)
            {
                nr.Text = "#6";
                poza.BackgroundImage = Properties.Resources.ar6;
                explicatie.Visible = true; all = 1;
                texte();
            }else if (m == 7)
            {
                next1.Visible = false;
                nr.Text = "#7";
                poza.BackgroundImage = Properties.Resources.cal;
                descriere1.Visible = true;
               descriere1.Text ="  Numarul total al cailor ce au murit in WW1 se ridica la 8 milioane; acestia au devenit eroii necuvantatori ai razboiului"+Environment.NewLine+ "  Pe timp de război, calul este cel mai bun prieten al omului și cel mai prezent animal pe câmpul de luptă, fie că trăgeau carele, transportau echipament sau mergeau la luptă cu soldații."+Environment.NewLine+". Totuși, la momentul izbucnirii Primului Război Mondial, dezvoltările tehnologice în domeniul militar au făcut ca situația de pe front să fie mai periculoasă pentru cai decât pentru oameni."+Environment.NewLine+ "  Caii au dovedit o sensibilitate mai mare și față de alte elemente și sute de cai ai dispărut din cauza extenuării, a bolilor sau a atacurilor cu gaze toxice."+Environment.NewLine+" Și mult mai mare ar fi fost numărul animalelor ucise dacă nu interveneau unitățile veterinare. În cazul armatei britanice, au fost tratați peste două milioane și jumătate de cai răniți, dintre care 75% s-au putut întoarce la serviciu.";
            }else if (m == 8)
            {
                next1.Visible = false;
                nr.Text = "#8";
                poza.BackgroundImage = Properties.Resources.licurici;
                descriere1.Visible = true;
                descriere1.Text = "  Una dintre cele mai uimitoare contribuții ale viețuitoarelor din lumea animală este aceea a Lampyris noctiluca, adică a licuricilor."+Environment.NewLine+"  Ghemuiți prin tranșeele umede și întunecoase, bărbați înrolați și ofițeri au adunat în borcane mii de licurici."+Environment.NewLine+" Micile lanterne efemere le-au permis soldaților să citească rapoarte secrete, să studieze hărți de război sau să citească scrisori de la cei dragi rămași acasă."+Environment.NewLine+" Conform unui studiu realizat în 2010, numai 10 licurici pot furniza aceeași cantitate de lumină precum o lampă stradală modernă.";
            }else if (m == 9)
            {
                next1.Visible = false;
                nr.Text = "#9";
                poza.BackgroundImage = Properties.Resources.porumbel;
                descriere1.Visible = true;
                descriere1.Text = "  Porumbeii mesageri au fost folositi la transmiterea mesajelor militare. In Primul Razboi Mondial, SUA si Marea Britanie au pus bazele unor unitati speciale pentru formarea pasagerilor inaripati."+Environment.NewLine+ "  Peste 16.000 de porumbei au fost lansați în Europa în timpul celui de-al Doilea Război Mondial, printre care și Gustav (înregistrat oficial NPS.42.31066), un porumbel care a zburat peste 250 de kilometri înapoi în Anglia pentru a transmite prima veste oficială despre debarcarea din Normandia.";
            }else if (m == 10)
            {
                next1.Visible = false;
                nr.Text = "#10";
                poza.BackgroundImage = Properties.Resources.stubby;
                descriere1.Visible = true;
                descriere1.Text = "  În 1917, un cățeluș vagabond cutreiera campusul Universității Yale, unde se antrenau membrii Regimentului de Infanterie 102. Micul pit bull a câștigat simpatia unității cu șotiile sale, participând la exerciții și învățând chiar să salute cu laba dreaptă. Soldatul J. Robert Conroy l-a adoptat și l-a botezat Stubby."+Environment.NewLine+ "  Stubby a fost educat și să identifice, în timpul patrulelor, soldații răniți. Într-una din zile, Stubby a descoperit un spion german pe care, spre uimirea acestuia, l-a atacat până când au venit întăriri. "+Environment.NewLine+ "  În cele 18 luni de serviciu, Stubby a participat la 17 bătălii, a supraviețuit unor serii de răni și, nu în ultimul rând, s-a dovedit a fi sprijinul moral de care soldații aveau nevoie.  ";
              
            }
            else if (m == 11)
            {
                nr.Text = "#11";
                poza.BackgroundImage = Properties.Resources.ar7;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 12)
            {
                nr.Text = "#12";
                poza.BackgroundImage = Properties.Resources.ar8;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 13)
            {
                nr.Text = "#13";
                poza.BackgroundImage = Properties.Resources.ar9;
            }
            else if (m == 14)
            {
                nr.Text = "#14";
                poza.BackgroundImage = Properties.Resources.ar10;
            }
            else if (m == 15)
            {
                nr.Text = "#15";
                poza.BackgroundImage = Properties.Resources.ar11;
            }
            else if (m == 16)
            {
                nr.Text = "#16";
                poza.BackgroundImage = Properties.Resources.ar12;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 17)
            {
                nr.Text = "#17";
                poza.BackgroundImage = Properties.Resources.ar13;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 18)
            {
                nr.Text = "#18";
                poza.BackgroundImage = Properties.Resources.ar14;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 19)
            {
                nr.Text = "#19";
                poza.BackgroundImage = Properties.Resources.ar15;
            }
            else if (m == 20)
            {
                nr.Text = "#20";
                poza.BackgroundImage = Properties.Resources.ar16;
            }
            else if (m == 21)
            {
                nr.Text = "#21";
                poza.BackgroundImage = Properties.Resources.ar17;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 22)
            {
                nr.Text = "#22";
                poza.BackgroundImage = Properties.Resources.ar18;
            }
            else if (m == 23)
            {
                nr.Text = "#23";
                poza.BackgroundImage = Properties.Resources.ar19;
            }
            else if (m == 24)
            {
                nr.Text = "#24";
                poza.BackgroundImage = Properties.Resources.ar20;
            }
            else if (m == 25)
            {
                nr.Text = "#25";
                poza.BackgroundImage = Properties.Resources.ar21;
                explicatie.Visible = true; all = 1;
                texte();

            }
            else if (m == 26)
            {
                nr.Text = "#26";
                poza.BackgroundImage = Properties.Resources.ar22;
            }
            else if (m == 27)
            {
                nr.Text = "#27";
                poza.BackgroundImage = Properties.Resources.ar23;
            }
            else if (m == 28)
            {
                nr.Text = "#28";
                poza.BackgroundImage = Properties.Resources.ar24;
            }
            else if (m == 29)
            {
                nr.Text = "#29";
                poza.BackgroundImage = Properties.Resources.ar25;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 30)
            {
                nr.Text = "#30";
                poza.BackgroundImage = Properties.Resources.ar26;
            }
            else if (m == 31)
            {
                nr.Text = "#31";
                poza.BackgroundImage = Properties.Resources.ar27;
            }
            else if (m == 32)
            {
                nr.Text = "#32";
                poza.BackgroundImage = Properties.Resources.ar28;
            }
            else if (m == 33)
            {
                nr.Text = "#33";
                poza.BackgroundImage = Properties.Resources.ar29;
            }
            else if (m == 34)
            {
                nr.Text = "#34";
                poza.BackgroundImage = Properties.Resources.ar30;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 35)
            {
                nr.Text = "#35";
                poza.BackgroundImage = Properties.Resources.ar31;
                explicatie.Visible = true; all = 1;
                texte();

            }
            else if (m == 36)
            {
                nr.Text = "#36";
                poza.BackgroundImage = Properties.Resources.ar32;
                explicatie.Visible = true; all = 1;
                texte();

            }
            else if (m == 37)
            {
                nr.Text = "#37";
                poza.BackgroundImage = Properties.Resources.ar33;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 38)
            {
                nr.Text = "#38";
                poza.BackgroundImage = Properties.Resources.ar34;
            }
            else if (m == 39)
            {
                nr.Text = "#39";
                poza.BackgroundImage = Properties.Resources.ar35;
            }
            else if (m == 40)
            {
                nr.Text = "#40";
                poza.BackgroundImage = Properties.Resources.ar36;
            }
            else if (m == 41)
            {
                nr.Text = "#41";
                poza.BackgroundImage = Properties.Resources.ar37;
            }
            else if (m == 42)
            {
                nr.Text = "#42";
                poza.BackgroundImage = Properties.Resources.ar38;
            }
            else if (m == 43)
            {
                nr.Text = "#43";
                poza.BackgroundImage = Properties.Resources.ar39;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 44)
            {
                nr.Text = "#44";
                poza.BackgroundImage = Properties.Resources.ar40;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 45)
            {
                nr.Text = "#45";
                poza.BackgroundImage = Properties.Resources.ar41;
            }
            else if (m == 46)
            {
                nr.Text = "#46";
                poza.BackgroundImage = Properties.Resources.ar42;
            }
            else if (m == 47)
            {
                nr.Text = "#47";
                poza.BackgroundImage = Properties.Resources.ar43;
            }
            else if (m == 48)
            {
                nr.Text = "#48";
                poza.BackgroundImage = Properties.Resources.ar44;
            }
            else if (m == 49)
            {
                nr.Text = "#49";
                poza.BackgroundImage = Properties.Resources.ar45;
                next2.Visible = next_pict.Visible = false;
                explicatie.Visible = true; all = 1;
                texte();
            }
            else if (m == 50)
            {
                nr.Text = "#50";
                poza.BackgroundImage = Properties.Resources.ar46;
            }
            else if (m == 51)
            {
                nr.Text = "#51";
                poza.BackgroundImage = Properties.Resources.ar47;
            }
            else if (m == 52)
            {
                nr.Text = "#52";
                poza.BackgroundImage = Properties.Resources.ar48;
            }
            else if (m == 53)
            {
                nr.Text = "#53";
                poza.BackgroundImage = Properties.Resources.ar49;
                next2.Visible = next_pict.Visible = false;
            }





        }


        private void explicatie_Click(object sender, EventArgs e)
        {
            all = 1 - all;
            texte();
        }

        private void prev_pict_Click(object sender, EventArgs e)
        {
            if (m > 1)
            {
                m--; navigare();
            }
        }

        private void prev1_Click(object sender, EventArgs e)
        {
            if (m > 1)
            {
                m--; navigare();
            }
        }

        private void next_pict_Click(object sender, EventArgs e)
        {
            if (m != 49)
            {
                m++;
                navigare();
            }
        }

        private void next2_Click(object sender, EventArgs e)
        {
            if (m != 49)
            {
                m++;
                navigare();
            }
        }

        private void next1_Click(object sender, EventArgs e)
        {
            if (m != 49)
            {
                m++;
                navigare();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
        }













        private void OnMouseEnterX(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.remove_2;
        }

        private void OnMouseLeaveX(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.remove__1;
        }
        private void OnMouseEnterprev(object sender, EventArgs e)
        {
            prev1.BackColor = prev_pict.BackColor = Color.Goldenrod;
        }
        private void OnMouseLeaveprev(object sender, EventArgs e)
        {
            prev1.BackColor = prev_pict.BackColor = Color.FromArgb(22, 18, 88);
        }


        private void OnMouseEnternext(object sender, EventArgs e)
        {
            next1.BackColor = next2.BackColor = next_pict.BackColor = Color.Goldenrod;
        }
        private void OnMouseLeavenext(object sender, EventArgs e)
        {
            next1.BackColor = next2.BackColor = next_pict.BackColor = Color.FromArgb(22, 18, 88);
        }
    }
}
