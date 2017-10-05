using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood
{
    [Serializable]
    public class Calories
    {

        public Dictionary<string, int> _Cal = new Dictionary<string, int>
        {
            {"oeuf",155 }, {" Steak de boeuf", 148},{"Collier de boeuf",124},{"Entrecote de boeuf", 192}, {"Cote de boeuf",355}, { "Rumsteck de boeuf", 123},
            {"Jarret de boeuf", 170}, {"Onglet de boeuf", 200}, {"Flanchet de boeuf", 194},{"Poitrine de boeuf", 148},{ "Bifteck de boeuf",147 },
            {"Collier d'agneau", 251}, {"Cote d'agneau", 234 },{"Filet d'agneau", 114}, {"Gigot d'agneau", 294 },{ "Poitrine d'agneau", 172},
            {"Epaule d'agneau", 172 }, {"Collier de veau", 124}, {"Cote de veau", 234}, {"Filet de veau", 138}, {"Poitrine de veau",120},
            {"Epaule de veau",116}, {"Jarret de veau", 109}, {"Flanchet de veau",231},{"Tendron de veau",201}, {"Echine de porc", 302},
            {"Cote de porc",276 },{"Filet de porc", 195}, {"Jambon de porc", 145},  {"Jarret de porc", 263}, {"Collier de cheval", 124},
            {"Cote de cheval",237},{"Entrecote de cheval",118},{"Filet de cheval", 120}, {"Rumsteck de cheval", 120}, {"Gite de cheval", 158 },
            {"Jarret de cheval", 161},{ "Filet de boeuf", 324},{"anchois", 210},{"anguille", 248}, {"brochet", 97},{"cabillaud", 82},{"colin", 91},{"daurade royale",91},{"flétan", 186},
            {"loup de mer", 105},{"merlan",91},{"omble chevalier", 118},{"perche", 105},{"aiglefin frais", 80},{"plie", 76},{"raie", 86},{"rascasse du nord", 91},
            {"rouget barbet", 113},{"sandre", 83},{"sardine",208},{"saumon", 208},{"sole",73},{"thon", 136},{ "blanc de poulet", 121 },{"cuisses de poulet", 190},{ "pattes de poulet", 122},{"pilons de poulet", 196},{"ailes de poulet", 266},
            {"gesier de poulet", 94},{ "foie de poulet", 160},{ "coeur de poulet", 95},{"blanc de dinde", 106}, { "aiguillette de dinde", 102},
            {"escalope de dinde",106},{ "filet de dinde", 106},{ "supreme de dinde",106}, { "aileron de dinde",170}, { "manchon de dinde",213},
            {"cuisses de dinde",171},{ "pilon de dinde",108},{"aiguillettes de canard",123},{"cuisses de canard", 217},
            {"filet de canard", 205},{"tournedos de canard",124},{"aiguillettes de pintade",108},{"cuisses de pintade",108},{"filet de pintade",108},
            {"tournedos de pintade",108 },{"abricot", 48},{"amande", 634},{"ananas",50},{"avocat", 220},{"banane",90},{"cacahuète",560},{"canneberge",28}, {"carambole",39},
            {"cassis",53},{"cerise",50}, {"citron",30},{"clémentine",40},{"datte",304},{"fraise",32},{"frambroise",53},{"goyave",52},
            {"grenade",64},{"grenadelle",102},{"merise",103},{"melon",29},{"pistache",630},{"pastèque",29}, {"poire",60},{"pomme",54}, {"raisin", 68 },{"boulgour", 342 },{"flageolet",84},{"haricot rouge",329},{"haricot blanc", 67},{"lentille", 116},{"patate douce", 86},{"pois cassé", 341},
            {"polanta", 62},{"pomme de terre", 77},{"quinoa",380},{"riz", 130},{"soisson", 67},{"manioc", 159},{"aubergine", 25}, {"concombre", 16},{"cornichon",28},{"courgette", 17}, {"couge de siam", 37},
            {"piment fort",40}, {"tomate",18}, {"poivrons", 20},{"yaourt", 59},{"beurre", 717},{"lait de vache", 42},{"lait cru", 63},{"lait concentré", 321},{"lait en poudre", 496},{"lait demi écrémé",46},
            {"lait entier",64},{"lait écrémé", 33},{"crème", 301}, {"crème glacée", 207},{"lait au bifidus",66},{"fromage frais", 85},{"fromage fermier",84},
            {"milkshake",112 },{"araignee de mer",95}, {"cigale de mer",117},{"crabe",128},{"crevette grise", 101},{"crevette rose", 88},{"ecrevisse", 87},
            {"etrille", 220},{"gambas",98},{"homard", 89},{"langouste", 143},{"langoustine", 88},{"tourteau", 128},{"rigadeau",213},
            {"rigadelle",45},{"berberechos",79},{"huitre",199},{"moule", 57},{"palourde", 148},{"petoncle", 111},{"couteau de mer", 55},{"vin blanc", 86},
            {"poulpe", 86},{"pieuvre", 86},{"buccin", 99},{"bourgot", 99},{"bulot", 99},{"meduse",36 },{"tarte aux cérises", 312},{"gâteau au yaourt",200},{"salade de fruits",50}, {"pain perdu",229},{"tarte à la crème de marron et de coco", 304},
            {"tarte aux pommes et à la vergeoise",237},{"gâteau à la courge de nice",210},{"caramel mou au beurre salé",430},{"muffins aux pommes",247},
            {"baba au rhum",234},{"moelleux au chocolat",459},{"poires au vin",370},{"tarte à la rhubarbe",319},{"charlotte russe aux pommes",167},
            {"cake au citron et aux graines de pavot",445},{"fondant au chocolat",440},{"makrouts",253},{"quatre quart caramélisé aux pommes",388},
            {"cheese cake aux spéculoos",388},{"cookies aux deux noix",88},{"muffins vegan cacoo noisette",35},{"cookies noisettes",504},
            {"épeautre et chocolat",338}, {"fraises au yaourt",128},{"cake poire noisette chocolat",280},{"muffins au chocolat", 392},
        };
        public Dictionary<string,int> Cal
        {
            get { return _Cal; }
        }

        
    }
}