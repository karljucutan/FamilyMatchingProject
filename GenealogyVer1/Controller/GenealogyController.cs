using GenealogyVer1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenealogyVer1.Controller;
using System.Linq;


namespace GenealogyVer1.Controller
{
    public class GenealogyController
    {
        //level 0 index 0 - person
        //level 1 index 1 - father
        //level 1 index 2 - mother      left node always father, right node always mother
        //level 2 index 3 - grandfather( father side )
        //level 2 index 4 - grand mother( father side )
        //level 2 index 5 - grandfather( mother side )
        //level 2 index 6 - grandmother( mother side )
        //and so on.....
        // get level using f(x) = 2X ; x is yung result, starts with 1

        Person[][] Person1Tree;
        
        
        public readonly string[,] OLDTOYOUNGINDIRECTFAMILYRELATIONMALE = new string[8, 8] 
        {{"Brother","Nephew","Grand-Nephew","Great-Grand-Nephew","2nd Great-Grand-Nephew", "3rd Great-Grand-Nephew", "4th Great-Grand-Nephew", "5th Great-Grand-Nephew" },
        { "Nephew", "First Cousin","First Cousin Once Removed","First Twice Removed","First Cousin 3x Removed","First Cousin 4x Removed", "First Cousin 5x Removed", "First Cousin 6x Removed" },
        { "Grand-Newphew", "First Cousin Once Removed","Second Cousin","Second Cousin Once Removed","Second Cousin Twice Removed","Second Cousin 3x Removed", "Second Cousin 4x Removed", "Second Cousin 5x Removed" },
        { "Great-Grand-Nephew", "First Cousin Twice Removed","Second Cousin Once Removed","Third Cousin","Third Cousin Once Removed","Third Cousin Twice Removed", "Third Cousin 3x Removed", "Third Cousin 4x Removed" },
        { "2nd Great-Grand-Nephew", "First Cousin 3x Removed","Second Cousin Twice Removed","Third Cousin Once Removed","Fourth Cousin","Fourth Cousin Once Removed", "Fourth Cousin Twice Removed", "Fourth Cousin 3x Removed" },
        { "3rd Great-Grand-Nephew", "First Cousin 4x Removed","Second Cousin 3x Removed","Third Cousin Twice Removed","Fourth Cousin Once Removed","Fifth Cousin", "Fifth Cousin Once Removed", "Fifth Cousin Twice Removed" },
        { "4th Great-Grand-Nephew", "First Cousin 5x Removed","Second Cousin 4x Removed","Third Cousin 3x Removed","Fourth Cousin Twice Removed","Fifth Cousin Once Removed", "Sixth Cousin", "Sixth Cousin Once Removed" },
        { "5th Great-Grand-Nephew", "First Cousin 6x Removed","Second Cousin 5x Removed","Third Cousin 4x Removed","Fourth Cousin 3x Removed","Fifth Cousin Twice Removed", "Sixt Cousin Once Removed", "Seventh Cousin" }};

        public readonly string[,] OLDTOYOUNGINDIRECTFAMILYRELATIONFEMALE = new string[8, 8] 
        {{"Sister","Niece","Grand-Niece","Great-Grand-Niece","2nd Great-Grand-Niece", "3rd Great-Grand-Niece", "4th Great-Grand-Niece", "5th Great-Grand-Niece" },
        { "Nephew", "First Cousin","First Cousin Once Removed","First Twice Removed","First Cousin 3x Removed","First Cousin 4x Removed", "First Cousin 5x Removed", "First Cousin 6x Removed" },
        { "Grand-Niece", "First Cousin Once Removed","Second Cousin","Second Cousin Once Removed","Second Cousin Twice Removed","Second Cousin 3x Removed", "Second Cousin 4x Removed", "Second Cousin 5x Removed" },
        { "Great-Grand-Niece", "First Cousin Twice Removed","Second Cousin Once Removed","Third Cousin","Third Cousin Once Removed","Third Cousin Twice Removed", "Third Cousin 3x Removed", "Third Cousin 4x Removed" },
        { "2nd Great-Grand-Niece", "First Cousin 3x Removed","Second Cousin Twice Removed","Third Cousin Once Removed","Fourth Cousin","Fourth Cousin Once Removed", "Fourth Cousin Twice Removed", "Fourth Cousin 3x Removed" },
        { "3rd Great-Grand-Niece", "First Cousin 4x Removed","Second Cousin 3x Removed","Third Cousin Twice Removed","Fourth Cousin Once Removed","Fifth Cousin", "Fifth Cousin Once Removed", "Fifth Cousin Twice Removed" },
        { "4th Great-Grand-Niece", "First Cousin 5x Removed","Second Cousin 4x Removed","Third Cousin 3x Removed","Fourth Cousin Twice Removed","Fifth Cousin Once Removed", "Sixth Cousin", "Sixth Cousin Once Removed" },
        { "5th Great-Grand-Niece", "First Cousin 6x Removed","Second Cousin 5x Removed","Third Cousin 4x Removed","Fourth Cousin 3x Removed","Fifth Cousin Twice Removed", "Sixt Cousin Once Removed", "Seventh Cousin" }};


        //4 arrays 2 arrays male and female for immediate(direct) and 2 arrays male and female for unimmediate(not direct)
        public readonly string[,] OLDTOYOUNGDIRECTFAMILYRELATIONMALE = new string[8, 8] 
        {{"Brother","Son","Grand-Son","Great-Grand-Son","2nd Great-Grand-Son", "3rd Great-Grand-Son", "4th Great-Grand-Son", "5th Great-Grand-Son" },
        { "Son", null, null, null, null, null, null, null },
        { "Grand-Son", null, null, null, null, null, null, null },
        { "Great-Grand-Son", null, null, null, null, null, null, null },
        { "2nd Great-Grand-Son", null, null, null, null, null, null, null },
        { "3rd Great-Grand-Son", null, null, null, null, null, null, null },
        { "4th Great-Grand-Son", null, null, null, null, null, null, null },
        { "5th Great-Grand-Son", null, null, null, null, null, null, null }};

        public readonly string[,] OLDTOYOUNGDIRECTFAMILYRELATIONFEMALE = new string[8, 8] 
        {{"Sister", "Daughter", "Grand-Daughter","Great-Grand-Daughter","2nd Great-Grand-Daughter", "3rd Great-Grand-Daughter", "4th Great-Grand-Daughter", "5th Great-Grand-Daughter" },
        { "Daughter", null, null, null, null, null, null, null },
        { "Grand-Daughter", null, null, null, null, null, null, null },
        { "Great-Grand-Daughter", null, null, null, null, null, null, null },
        { "2nd Great-Grand-Daughter", null, null, null, null, null, null, null },
        { "3rd Great-Grand-Daughter", null, null, null, null, null, null, null },
        { "4th Great-Grand-Daughter", null, null, null, null, null, null, null },
        { "5th Great-Grand-Daughter", null, null, null, null, null, null, null }};

        public readonly string[,] YOUNGTOOLDINDIRECTFAMILYRELATIONMALE = new string[8, 8]
        {{"Brother","Uncle","Grand-Uncle","Great-Grand-Uncle","2nd Great-Grand-Uncle", "3rd Great-Grand-Uncle", "4th Great-Grand-Uncle", "5th Great-Grand-Uncle" },
        { "Uncle", "First Cousin","First Cousin Once Removed","First Twice Removed","First Cousin 3x Removed","First Cousin 4x Removed", "First Cousin 5x Removed", "First Cousin 6x Removed" },
        { "Grand-Uncle", "First Cousin Once Removed","Second Cousin","Second Cousin Once Removed","Second Cousin Twice Removed","Second Cousin 3x Removed", "Second Cousin 4x Removed", "Second Cousin 5x Removed" },
        { "Great-Grand-Uncle", "First Cousin Twice Removed","Second Cousin Once Removed","Third Cousin","Third Cousin Once Removed","Third Cousin Twice Removed", "Third Cousin 3x Removed", "Third Cousin 4x Removed" },
        { "2nd Great-Grand-Uncle", "First Cousin 3x Removed","Second Cousin Twice Removed","Third Cousin Once Removed","Fourth Cousin","Fourth Cousin Once Removed", "Fourth Cousin Twice Removed", "Fourth Cousin 3x Removed" },
        { "3rd Great-Grand-Uncle", "First Cousin 4x Removed","Second Cousin 3x Removed","Third Cousin Twice Removed","Fourth Cousin Once Removed","Fifth Cousin", "Fifth Cousin Once Removed", "Fifth Cousin Twice Removed" },
        { "4th Great-Grand-Uncle", "First Cousin 5x Removed","Second Cousin 4x Removed","Third Cousin 3x Removed","Fourth Cousin Twice Removed","Fifth Cousin Once Removed", "Sixth Cousin", "Sixth Cousin Once Removed" },
        { "5th Great-Grand-Uncle", "First Cousin 6x Removed","Second Cousin 5x Removed","Third Cousin 4x Removed","Fourth Cousin 3x Removed","Fifth Cousin Twice Removed", "Sixt Cousin Once Removed", "Seventh Cousin" }};

        public readonly string[,] YOUNGTOOLDINDIRECTFAMILYRELATIONFEMALE = new string[8, 8]
        {{"Sister","Aunt","Grand-Aunt","Great-Grand-Aunt","2nd Great-Grand-Aunt", "3rd Great-Grand-Aunt", "4th Great-Grand-Aunt", "5th Great-Grand-Aunt" },
        { "Aunt", "First Cousin","First Cousin Once Removed","First Twice Removed","First Cousin 3x Removed","First Cousin 4x Removed", "First Cousin 5x Removed", "First Cousin 6x Removed" },
        { "Grand-Aunt", "First Cousin Once Removed","Second Cousin","Second Cousin Once Removed","Second Cousin Twice Removed","Second Cousin 3x Removed", "Second Cousin 4x Removed", "Second Cousin 5x Removed" },
        { "Great-Grand-Aunt", "First Cousin Twice Removed","Second Cousin Once Removed","Third Cousin","Third Cousin Once Removed","Third Cousin Twice Removed", "Third Cousin 3x Removed", "Third Cousin 4x Removed" },
        { "2nd Great-Grand-Aunt", "First Cousin 3x Removed","Second Cousin Twice Removed","Third Cousin Once Removed","Fourth Cousin","Fourth Cousin Once Removed", "Fourth Cousin Twice Removed", "Fourth Cousin 3x Removed" },
        { "3rd Great-Grand-Aunt", "First Cousin 4x Removed","Second Cousin 3x Removed","Third Cousin Twice Removed","Fourth Cousin Once Removed","Fifth Cousin", "Fifth Cousin Once Removed", "Fifth Cousin Twice Removed" },
        { "4th Great-Grand-Aunt", "First Cousin 5x Removed","Second Cousin 4x Removed","Third Cousin 3x Removed","Fourth Cousin Twice Removed","Fifth Cousin Once Removed", "Sixth Cousin", "Sixth Cousin Once Removed" },
        { "5th Great-Grand-Aunt", "First Cousin 6x Removed","Second Cousin 5x Removed","Third Cousin 4x Removed","Fourth Cousin 3x Removed","Fifth Cousin Twice Removed", "Sixt Cousin Once Removed", "Seventh Cousin" }};

        public readonly string[,] YOUNGTOOLDDIRECTFAMILYRELATIONMALE = new string[8, 8]
        {{"Brother","Father","Grand-Father","Great-Grand-Father","2nd Great-Grand-Father", "3rd Great-Grand-Father", "4th Great-Grand-Father", "5th Great-Grand-Father" },
        { "Father", null, null, null, null, null, null, null },
        { "Grand-Father", null, null, null, null, null, null, null },
        { "Great-Grand-Father", null, null, null, null, null, null, null },
        { "2nd Great-Grand-Father", null, null, null, null, null, null, null },
        { "3rd Great-Grand-Father", null, null, null, null, null, null, null },
        { "4th Great-Grand-Father", null, null, null, null, null, null, null },
        { "5th Great-Grand-Father", null, null, null, null, null, null, null }};

        public readonly string[,] YOUNGTOOLDDIRECTFAMILYRELATIONFEMALE = new string[8, 8]
        {{"Brother","Mother","Grand-Mother","Great-Grand-Mother","2nd Great-Grand-Mother", "3rd Great-Grand-Mother", "4th Great-Grand-Mother", "5th Great-Grand-Mother" },
        { "Mother", null, null, null, null, null, null, null },
        { "Grand-Mother", null, null, null, null, null, null, null },
        { "Great-Grand-Mother", null, null, null, null, null, null, null },
        { "2nd Great-Grand-Mother", null, null, null, null, null, null, null },
        { "3rd Great-Grand-Mother", null, null, null, null, null, null, null },
        { "4th Great-Grand-Mother", null, null, null, null, null, null, null },
        { "5th Great-Grand-Mother", null, null, null, null, null, null, null }};

        public void KealuFamily()
        {
            Person kealu = new Person();
            kealu.name = "Kealu Rullamas";
            kealu.father = "Abraham Rullamas";
            kealu.mother = "Mucha Rullamas";
            kealu.gender = "Male";
            Person khirvey = new Person();
            khirvey.name = "Khirvey Rullamas";
            khirvey.father = "Abraham Rullamas";
            khirvey.mother = "Mucha Rullamas";
            khirvey.gender = "Male";
            Person Abraham = new Person();
            Abraham.name = "Abraham Rullamas";
            Abraham.father = "Felix Rullamas";
            Abraham.mother = "Odeth Rullamas";
            Abraham.gender = "Male";
            Person Mucha = new Person();
            Mucha.name = "Mucha Rullamas";
            Mucha.father = "Bonifacio Sanchez";
            Mucha.mother = "Caridad Sanchez";
            Mucha.gender = "Female";
            Person Felix = new Person();
            Felix.name = "Felix Rullamas";
            Felix.father = "Tatay ni Felix";
            Felix.mother = "Nanay ni Felix";
            Felix.gender = "Male";
            Person Odeth = new Person();
            Odeth.name = "Odeth Rullamas";
            Odeth.father = "Tatay ni Odeth";
            Odeth.mother = "Nanay ni Odeth";
            Odeth.gender = "Female";
            Person Bonifacio = new Person();
            Bonifacio.name = "Bonifacio Sanchez";
            Bonifacio.father = "Tatay ni Bonifacio";
            Bonifacio.mother = "Nanay ni Bonifacio";
            Bonifacio.gender = "Male";
            Person Caridad = new Person();
            Caridad.name = "Caridad Sanchez";
            Caridad.father = "Tatay ni CaridadatBerto";
            Caridad.mother = "Nanay ni CaridadatBerto";
            Caridad.gender = "Female";
            Person Rico = new Person();
            Rico.name = "Rico Sanchez";
            Rico.father = "Bonifacio Sanchez";
            Rico.mother = "Caridad Sanchez";
            Rico.gender = "Male";
            Person Patoy = new Person();
            Patoy.name = "Patoy Jr.";
            Patoy.father = "Patoy Sr.";
            Patoy.mother = "Nilda";
            Patoy.gender = "Male";
            Person PatoySr = new Person();
            PatoySr.name = "Patoy Sr.";
            PatoySr.father = "Berto";
            PatoySr.mother = "Siling";
            PatoySr.gender = "Male";
            Person Berto = new Person();
            Berto.name = "Berto";
            Berto.father = "Tatay ni CaridadatBerto";
            Berto.mother = "Nanay ni CaridadatBerto";
            Berto.gender = "Male";
            Person Nilda = new Person();
            Nilda.name = "Nilda";
            Nilda.father = "Tatay ni Nilda";
            Nilda.mother = "Nanay ni Nilda";
            Nilda.gender = "Female";


            PersonController.ListofPerson.Add(kealu);
            PersonController.ListofPerson.Add(khirvey);
            PersonController.ListofPerson.Add(Abraham);
            PersonController.ListofPerson.Add(Mucha);
            PersonController.ListofPerson.Add(Felix);
            PersonController.ListofPerson.Add(Odeth);
            PersonController.ListofPerson.Add(Bonifacio);
            PersonController.ListofPerson.Add(Caridad);
            PersonController.ListofPerson.Add(Rico);
            PersonController.ListofPerson.Add(Patoy);
            PersonController.ListofPerson.Add(PatoySr);
            PersonController.ListofPerson.Add(Berto);
            PersonController.ListofPerson.Add(Nilda);
        }

        public Person[][] SupplyFamilyTree(string personName)
        {
            Person[][] familyTree = new Person[10][];                   // declaration of FamilyTree

            familyTree[0] = new Person[1];
            int countForInstantiation = 1;
            for (int i = 1; i<familyTree.Length; i++)                   // Instantiation of Arrays inside an Array ( Jagged Array)
                {   
                    countForInstantiation *= 2;
                    familyTree[i] = new Person[countForInstantiation];
                }

            try
            {
                int count = 1;                      //para sa max size of inner arrays
                int indexInPreviousLevel = 0;       //nag ttraverse sa previous level para pang supply ng father and mother

                familyTree[0][0] = PersonController.ListofPerson.Where(p => p.name.Equals(personName)).SingleOrDefault();   //for the root node, kung sino yung pinagcocompare
                for (int x = 1; x < familyTree.Length; x++)             
                {
                    indexInPreviousLevel = 0;
                    count *= 2;

                    for (int y = 0; y < count; y++)
                    {
                        if (familyTree[x - 1][indexInPreviousLevel] is Person)          // supply father and mother of the person in the previous level
                        {
                            var father = PersonController.ListofPerson.Where(p => p.name.Equals(familyTree[x - 1][indexInPreviousLevel].father)).SingleOrDefault() ?? null;
                            familyTree[x][y] = father;
                            y++;
                            var mother = PersonController.ListofPerson.Where(p => p.name.Equals(familyTree[x - 1][indexInPreviousLevel].mother)).SingleOrDefault();
                            familyTree[x][y] = mother;
                            indexInPreviousLevel++;
                        }
                        
                    }
                }
                return familyTree;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return familyTree;
            }
        }


        public List<KeyValuePair<int, Person>> ReturnCommonLevelAndPerson(Person [][] tree1, Person [][] tree2)
        {
            try
            {
                int tree1Count = 1, tree2Count = 1;

                for (int i = 0; i < tree1.Length; i++)                          // outer loop para sa jagged array ng first tree, tree[ETO][]
                {
                    if(i > 0)
                    {
                        tree1Count *= 2;
                    }
                    for (int j = 0; j < tree1Count; j++)                        // inner loop para sa traversal sa items ng jagged array ng first tree, tree[][ETO]
                    {
                        for (int k = 0; k < tree2.Length; k++)                  // outer loop para sa jagged array ng second tree, tree[ETO][]
                        {
                            if(k > 0)
                            {
                                tree2Count *= 2;
                            }
                            for (int l = 0; l < tree2Count; l++)                // inner loop para sa traversal sa items ng jagged array ng second tree, tree[][ETO]
                            {

                                if (tree2[k][l] == null)
                                {
                                     break;
                                }
                                if (tree1[i][j].father.Equals(tree2[k][l].father) && tree1[i][j].mother.Equals(tree2[k][l].mother))
                                {
                                    int[] level = new int[2];
                                    Person[] person = new Person[2];
                                    person[0] = tree1[0][0];
                                    person[1] = tree2[0][0];
                                    level[0] = i;
                                    level[1] = k;

                                    List<KeyValuePair<int, Person>> kplist = new List<KeyValuePair<int, Person>>()
                                    {
                                        new KeyValuePair<int, Person>(i, tree1[i][j]),
                                        new KeyValuePair<int, Person>(k, tree2[k][l])
                                    };

                                    Person1Tree = tree1;
                             
                                    return kplist;
                                }
                            }
                        }
                        tree2Count = 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            return null;
        }

        public string GetRelationship(string genderSecondPerson, int firstPersonLevel, int secondPersonLevel, string person2)
        {
            string relationship = "";
        
            if (genderSecondPerson.Equals("Male"))
            {
                relationship = Relationship(firstPersonLevel, secondPersonLevel, person2, YOUNGTOOLDDIRECTFAMILYRELATIONMALE, OLDTOYOUNGDIRECTFAMILYRELATIONMALE, YOUNGTOOLDINDIRECTFAMILYRELATIONMALE, OLDTOYOUNGINDIRECTFAMILYRELATIONMALE );
            }
            else // Female  
            {
                relationship = Relationship(firstPersonLevel, secondPersonLevel, person2, YOUNGTOOLDDIRECTFAMILYRELATIONFEMALE, OLDTOYOUNGDIRECTFAMILYRELATIONFEMALE, YOUNGTOOLDINDIRECTFAMILYRELATIONFEMALE, OLDTOYOUNGINDIRECTFAMILYRELATIONFEMALE);
            }
            return relationship;
        }

        private string Relationship(int firstPersonLevel, int secondPersonLevel, string person2, string[,] YoungToOldDirectRelation, string[,] OldToYoungDirectRelation, string[,] YoungToOldIndirectRelation, string[,] OldToYoungIndirectRelation)
        {
            string relationship = "";
            if (SearchIfDirectFamily(person2))  // Directfamily
            {
                if (firstPersonLevel > secondPersonLevel)    // lefside person is YOUNGER
                {
                    relationship = YoungToOldDirectRelation[firstPersonLevel, secondPersonLevel];      
                }
                else   // leftside person is OLDER
                {
                    relationship = OldToYoungDirectRelation[firstPersonLevel, secondPersonLevel];      
                }
            }
            else       // Indirectfamily
            {
                if (firstPersonLevel > secondPersonLevel)     // leftside person is YOUNGER
                {
                    relationship = YoungToOldIndirectRelation[firstPersonLevel, secondPersonLevel];
                }
                else    // leftside is OLDER
                {
                    relationship = OldToYoungIndirectRelation[firstPersonLevel, secondPersonLevel];}
            }
            return relationship;
        }

        public bool SearchIfDirectFamily(string person2)
        {
            bool direct = false;
            for (int i = 0; i < Person1Tree.Length; i++)
            {
                for (int j = 0; j < Person1Tree[i].Length; j++)
                {

                    if (Person1Tree[i][j] is Person)
                    {
                        if (Person1Tree[i][j].name.Equals(person2))
                        {
                            direct = true; return direct;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return direct;
        }

       

    }
}
