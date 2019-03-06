﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zoo_shop.Models
{
    public class PetForm
    {
        public string type { get; set; }
        public string[] Breed_dog =
        {
"Abruzzese Mastiff",
"Abyssinian Sand Terrier",
"Affenpinscher",
"Afghan Hound",
"Africanis",
"Aidi",
"Airedale Terrier",
"Akita",
"Aksaray Malaklisi dog",
"Alano Español",
"Alapaha Blue Blood Bulldog",
"Alaskan husky",
"Alaskan Klee Kai",
"Alaskan Malamute",
"Alpine Dachsbracke",
"Alpine Mastiff",
"Ameri Indian Alaskan Husky",
"American Bulldog",
"American Bully",
"American Cocker Spaniel",
"American English Coonhound",
"American Eskimo Dog",
"American Foxhound",
"American Hairless Terrier",
"American Pit Bull Terrier",
"American Staffordshire Terrier",
"American Water Spaniel",
"American Working Red",
"Anatolian Shepherd",
"Andalusian Hound",
"Andalusian Hound Maneto",
"Anglo Français de Petite Vénerie",
"Appenzeller Sennenhund",
"Ariege Pointer",
"Ariegeois",
"Armant dog",
"Artois Hound",
"Australian Cattle Dog",
"Australian Kelpie",
"Australian Shepherd",
"Australian Silky Terrier",
"Australian Staghound",
"Australian Stumpy Tail Cattle Dog",
"Australian Terrier",
"Austrian Black and Tan Hound",
"Austrian Pinscher",
"Azawakh",
"Bakharwal dog",
"Bakhmull",
"Bandog",
"Barak dog",
"Barak hound",
"Barbet dog",
"Basenji",
"Basque Shepherd Dog",
"Basset Artésien Normand",
"Basset Bleu de Gascogne",
"Basset Fauve de Bretagne",
"Basset Hound",
"Bavarian Mountain Hound",
"Beagle",
"Beagle Harrier",
"Bearded Collie",
"Beauceron",
"Bedlington Terrier",
"Belgian Draft Dog",
"Belgian Shepherd",
"Bergamasco Shepherd",
"Berger Blanc Suisse",
"Berger Picard",
"Bernese Mountain Dog",
"Bichon Frise",
"Billy",
"Black and Tan Coonhound",
"Black and Tan Virginia Foxhound",
"Black Norwegian Elkhound",
"Black Russian Terrier",
"Bloodhound",
"Blue Lacy",
"Blue Picardy Spaniel",
"Bluetick Coonhound",
"Boerboel",
"Bohemian Shepherd",
"Bolognese dog",
"Bolonka",
"Bone mouth",
"Border Collie",
"Border Terrier",
"Borzoi",
"Boston Terrier",
"Bouvier des Ardennes",
"Bouvier des Flandres",
"Boxer",
"Boykin Spaniel",
"Bracco Italiano",
"Braque dAuvergne",
"Braque du Bourbonnais",
"Braque Francais",
"Braque Saint Germain",
"Brazilian Bullmastiff",
"Brazilian Monster Pit",
"Brazilian Terrier",
"Breed club",
"Briard",
"Brindlequin",
"Briquet Griffon Vendéen",
"Brittany dog",
"Broholmer",
"Bruno Jura Hound",
"Bulgarian Scenthound",
"Bull Terrier",
"Bull baiter",
"Bulldog",
"Bullmastiff",
"Burgos Pointer",
"Ca Mè Mallorquí",
"Cairn Terrier",
"Calupoh",
"Campeiro Bulldog",
"Can de Chira",
"Can de Palleiro",
"Canaan Dog",
"Canadian Eskimo Dog",
"Cane Corso",
"Cane da presa",
"Cane di Oropa",
"Cane Lupino del Gigante",
"Cane Toccatore",
"Cantabrian Water Dog",
"Cão da Serra de Aires",
"Cão de Castro Laboreiro",
"Cão de Gado Transmontano",
"Cão Fila de São Miguel",
"Cardigan Welsh Corgi",
"Carea Castellano Manchego",
"Carea Leonés",
"Carpathian Shepherd Dog",
"Catalan Sheepdog",
"Caucasian Shepherd Dog",
"Cavalier King Charles Spaniel",
"Central Asian Shepherd Dog",
"Český fousek",
"Cesky Terrier",
"Chamuco",
"Chesapeake Bay Retriever",
"Chien Français Blanc et Noir",
"Chien Français Blanc et Orange",
"Chien Français Tricolore",
"Chihuahua",
"Chinese Crested Dog",
"Chinese Imperial Dog",
"Chippiparai",
"Chizer",
"Chow Chow",
"Cimarrón Uruguayo",
"Bucovina Shepherd Dog",
"Cirneco dellEtna",
"Clumber Spaniel",
"Colombian fino hound",
"Combai",
"Kinnaur Sheepdog",
"Continental bulldog",
"Coonhound",
"Coton de Tulear",
"Cretan Hound",
"Croatian Sheepdog",
"Curly coated Retriever",
"Czechoslovakian Wolfdog",
"Dachshund",
"Dalmatian dog",
"Dandie Dinmont Terrier",
"Danish Swedish Farmdog",
"Dobermann",
"Dogo Argentino",
"Dogo Sardesco",
"Dogue de Bordeaux",
"Double nosed Andean tiger hound",
"Drentse Patrijshond",
"Drever",
"Dumfriesshire hound",
"Dunker",
"Dutch Shepherd",
"Dutch Smoushond",
"East Siberian Laika",
"English Cocker Spaniel",
"English Foxhound",
"English Mastiff",
"English Setter",
"English Shepherd",
"English Springer Spaniel",
"English Toy Terrier",
"Entlebucher Mountain Dog",
"Estrela Mountain Dog",
"Eurasier",
"Fell Terrier",
"Field Spaniel",
"Fila Brasileiro",
"Finnish Hound",
"Finnish Lapphund",
"Finnish Spitz",
"Flat coated Retriever",
"Fox Terrier",
"Foxhound",
"French Spaniel",
"Galgo Español",
"Garafian Shepherd",
"Gascon Saintongeois",
"Gaucho sheepdog",
"Georgian Shepherd",
"German Hound",
"German Longhaired Pointer",
"German Pinscher",
"German Shepherd",
"German Shorthaired Pointer",
"German Spaniel",
"German Spitz",
"German Spitz Klein",
"German Spitz Mittel",
"German Wirehaired Pointer",
"Giant Schnauzer",
"Glen of Imaal Terrier",
"Goldador",
"Golden Retriever",
"Gordon Setter",
"Gran Mastín de Borínquen",
"Grand Anglo Français Blanc et Noir",
"Grand Anglo Français Blanc et Orange",
"Grand Anglo Français Tricolore",
"Grand Basset Griffon Vendéen",
"Grand Bleu de Gascogne",
"Grand Griffon Vendéen",
"Great Dane",
"Great Pyrenees",
"Greater Swiss Mountain Dog",
"Greek Harehound",
"Greek Shepherd",
"Greenland Dog",
"Greyhound",
"Griffon",
"Griffon Bleu de Gascogne",
"Griffon Bruxellois",
"Griffon Fauve de Bretagne",
"Griffon Nivernais",
"Groenendael dog",
"Halden Hound",
"Halls Heeler",
"Hamiltonstövare",
"Hanover Hound",
"Harlequin Pinscher",
"Harrier",
"Havanese dog",
"Hierran Wolfdog",
"Hokkaido dog",
"Hovawart",
"Hygen Hound",
"Hypoallergenic dog breed",
"Ibizan Hound",
"Icelandic Sheepdog",
"Illyrian Hound",
"Indian Spitz",
"Irish Red and White Setter",
"Irish Setter",
"Irish Terrier",
"Irish Water Spaniel",
"Irish wolfhound",
"Istrian Coarse haired Hound",
"Istrian Shorthaired Hound",
"Italian Greyhound",
"Italian Shepherd",
"Jagdterrier",
"Jämthund",
"Japanese Chin",
"Japanese Spitz",
"Japanese Terrier",
"Kai Ken",
"Kaikadi dog",
"Kangal Shepherd Dog",
"Kangaroo Dog",
"Kanni",
"Karakachan dog",
"Karelian Bear Dog",
"Karelo Finnish Laika",
"Karst Shepherd",
"Keeshond",
"Kerry Blue Terrier",
"King Charles Spaniel",
"King Shepherd",
"Kintamani dog",
"Kishu",
"Komondor",
"Kooikerhondje",
"Koolie",
"Korean Jindo",
"Koyun dog",
"Kromfohrländer",
"Kuchi dog",
"Kumaon Mastiff",
"Kuvasz",
"Kyi Leo",
"Labrador Retriever",
"Laekenois dog",
"Lagotto Romagnolo",
"Laika",
"Lakeland Terrier",
"Lancashire Heeler",
"Landseer dog",
"Lapponian Herder",
"Large Münsterländer",
"Leonberger",
"Levriero Italiano",
"Levriero Sardo",
"Lhasa Apso",
"List of dog breeds with little to no shedding",
"List of Labrador Retrievers",
"Lupo Italiano",
"Magyar agár",
"Maltese dog",
"Mantiqueira Shepherd Dog",
"Markiesje",
"McNab dog",
"Miniature American Shepherd",
"Miniature Fox Terrier",
"Miniature Shar Pei",
"Molosser",
"Mountain Cur",
"Mucuchies",
"Mudhol Hound",
"Münsterländer",
"New Guinea singing dog",
"Northern Inuit Dog",
"Old German Shepherd Dog",
"Old Spanish Pointer",
"Original Fila Brasileiro",
"Pachón Navarro",
"Pandikona",
"Papillon dog",
"Patterdale Terrier",
"Pekingese",
"Perdigueiro Galego",
"Perro Majorero",
"Phalène",
"Phu Quoc Ridgeback",
"Piccolo Segugio dellAppennino",
"Polish Hunting Dog",
"Poodle",
"Portuguese Water Dog",
"Pshdar dog",
"Rajapalayam dog",
"Rat Terrier",
"Ratonero Bodeguero Andaluz",
"Red Setter",
"Redbone Coonhound",
"Romanian Raven Shepherd Dog",
"Russell Terrier",
"Russian Spaniel",
"Russkiy Toy",
"Sabueso Cántabro",
"Sakhalin Husky",
"Sapsali",
"Sarabi Mastiff",
"Sardinian Shepherd Dog",
"Schnauzer",
"Scotch Collie",
"Scottish Deerhound",
"Segugio Cravin",
"Segugio dellAppennino",
"Seppala Siberian Sleddog",
"Serrano Bulldog",
"Shelillon dog",
"Shih Tzu",
"Shiloh Shepherd dog",
"Sinhala Hound",
"Sleuth hound",
"Sloughi",
"Spanish Water Dog",
"Sporting Lucas Terrier",
"Stephens Cur",
"Sulimov dog",
"Sussex Spaniel",
"Swinford Bandog",
"Taigan",
"Tamaskan Dog",
"Teddy Roosevelt Terrier",
"Telomian",
"Tenterfield Terrier",
"Terceira Mastiff",
"Tibetan Terrier",
"Torkuz",
"Tornjak",
"Toy Fox Terrier",
"Toy Manchester Terrier",
"Treeing Cur",
"List of US state dogs",
"Vanjari Hound",
"Vikhan Sheepdog",
"Welsh Corgi",
"Welsh Hillman",
"Welsh Hound",
"Welsh Sheepdog",
"Welsh Springer Spaniel",
"Wetterhoun",
"Whippet",
"Working Pit Bulldog",
"Xarnego Valenciano",
"Yakutian Laika"
    };
        public string[] Breed_cat =
        {
            "Abyssinian",
            "Aegean",
            "American Bobtail",
            "American Curl",
            "American Shorthair",
            "American Wirehair",
            "Aphrodite Giant",
            "Arabian Mau",
            "Asian",
            "Asian Semi longhair",
            "Australian Mist",
            "Balinese",
            "Bambino",
            "Bengal",
            "Birman",
            "Bombay",
            "Brazilian Shorthair",
            "British Longhair",
            "British Semi longhair",
            "British Shorthair",
            "Burmese",
            "Burmilla",
            "California Spangled",
            "Chantilly Tiffany",
            "Chartreux",
            "Chausie",
            "Cheetoh",
            "Colorpoint Shorthair",
            "Cornish Rex",
            "Cymric",
            "Cyprus",
            "Devon Rex",
            "Donskoy",
            "Dragon Li",
            "Dwelf",
            "Egyptian Mau",
            "European Shorthair",
            "Exotic Shorthair",
            "Foldex",
            "German Rex",
            "Havana Brown",
            "Highlander",
            "Himalayan",
            "Japanese Bobtail",
            "Javanese",
            "Karelian Bobtail",
            "Khao Manee",
            "Korat",
            "Korean Bobtail",
            "Korn Ja",
            "Kurilian Bobtail",
            "LaPerm",
            "Lykoi",
            "Maine Coon",
            "Manx",
            "Mekong Bobtail",
            "Minskin",
            "Munchkin",
            "Napoleon",
            "Nebelung",
            "Norwegian Forest Cat",
            "Ocicat",
            "Ojos Azules",
            "Oregon Rex",
            "Oriental Bicolor",
            "Oriental Longhair",
            "Oriental Shorthair",
            "Persian",
            "Peterbald",
            "Pixie bob",
            "Raas",
            "Ragamuffin",
            "Ragdoll",
            "Russian Blue",
            "Russian White",
            "Sam Sawet",
            "Savannah",
            "Scottish Fold",
            "Selkirk Rex",
            "Serengeti",
            "Serrade petit",
            "Siamese",
            "Siberian",
            "Singapura",
            "Snowshoe",
            "Sokoke",
            "Somali",
            "Sphynx",
            "Suphalak",
            "Thai Lilac",
            "Thai",
            "Tonkinese",
            "Toyger",
            "Turkish Angora",
            "Turkish Van",
            "Ukrainian Levkoy",
            "Wila Krungthep",
            "York Chocolate"
        };
    }
}
