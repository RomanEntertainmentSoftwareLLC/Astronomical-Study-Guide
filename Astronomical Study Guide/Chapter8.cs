using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Study_Guide
{
    class Chapter8
    {
        public enum QuestionType
        {
            MultipleChoice = 0,
            TrueOrFalse = 1
        };

        public int questionsInGame;
        private int numberOfQuestions;
        private int numberOfAnswers;
        public int minutes;
        public int seconds;
        private string[] question;
        public string[,] answer;
        public bool[] mastered;
        private int[] order;
        public int[] randomOrder;
        public int score;
        public int antiScore;
        public int questionNumber;
        public string text;
        public string yourAnswer;
        public QuestionType[] questiontype;

        private void Setup_Questions()
        {
            numberOfQuestions = 23;
            numberOfAnswers = 4;
            question = new string[numberOfQuestions];
            answer = new string[numberOfQuestions, numberOfAnswers];
            questiontype = new QuestionType[numberOfQuestions];
            mastered = new bool[numberOfQuestions];

            question[0] = "How does the composition of Uranus and Neptune compare to the composition of " + Environment.NewLine +
                "Jupiter and Saturn?"; answer[0, 0] = "Uranus and Neptune are mostly hydrogen compounds " + Environment.NewLine +
                "while Jupiter and Saturn are mostly hydrogen and helium."; answer[0, 1] = "Uranus and Neptune have compositions very similar to Jupiter " + Environment.NewLine +
                "and Saturn."; answer[0, 2] = "Uranus and Neptune are mostly rocky while Jupiter and Saturn " + Environment.NewLine +
                "are mostly hydrogen and helium."; answer[0, 3] = "Uranus and Neptune are mostly hydrogen and helium while " + Environment.NewLine +
                "Jupiter and Saturn are mostly hydrogen compounds."; questiontype[0] = QuestionType.MultipleChoice;
            question[1] = "How are the jovian planets affected by their rotation?"; answer[1, 0] = "Their rapid rotation causes the planets to be slightly " + Environment.NewLine +
                "flattened, larger across the equator than pole-to-pole."; answer[1, 1] = "Their rapid rotation causes the lighter elements hydrogen and " + Environment.NewLine +
                "helium to flung out to their outer layers and denser hydrogen " + Environment.NewLine +
                "compounds to settle in their cores."; answer[1, 2] = "Their rapid rotation causes a build up of hydrogen and helium " + Environment.NewLine +
                "near the equator and hydrogen compounds near the cores."; answer[1, 3] = "Their rapid rotation causes the planets to by stretched, larger " + Environment.NewLine +
                "pole-to-pole than across the equator."; questiontype[1] = QuestionType.MultipleChoice;
            question[2] = "The core of Jupiter is "; answer[2, 0] = "about the same size as Earth."; answer[2, 1] = "about the same mass as Earth."; answer[2, 2] = "about the same composition as Earth."; answer[2, 3] = "all of the above."; questiontype[2] = QuestionType.MultipleChoice;
            question[3] = "The interior of which jovian planet is heated by helium rain?"; answer[3, 0] = "Saturn"; answer[3, 1] = "Jupiter"; answer[3, 2] = "Uranus"; answer[3, 3] = "Neptune"; questiontype[3] = QuestionType.MultipleChoice;
            question[4] = "Why are methane clouds not seen on Jupiter and Saturn?"; answer[4, 0] = "The atmospheres of Jupiter and Saturn are too warm for methane clouds to form."; answer[4, 1] = "Jupiter and Saturn do not have enough methane to make clouds."; answer[4, 2] = "Because of their relatively warmer temperatures, Jupiter and " + Environment.NewLine +
                "Saturn have clouds of water that obscure our view of their " + Environment.NewLine +
                "methane clouds."; answer[4, 3] = "Jupiter and Saturn have sulfur compounds that combine with all " + Environment.NewLine +
                "their methane to make reddish methane-sulfide clouds."; questiontype[4] = QuestionType.MultipleChoice;
            question[5] = "What causes the white bands we see on Jupiter?"; answer[5, 0] = "Formation of ammonia clouds in regions of rising air."; answer[5, 1] = "Formation of water clouds in regions of rising air."; answer[5, 2] = "Gaps in ammonium hydrosulfide clouds revealing ammonia clouds below."; answer[5, 3] = "Gaps in ammonium hydrosulfide clouds revealing water clouds below."; questiontype[5] = QuestionType.MultipleChoice;
            question[6] = "Which of the jovian planets has no seasons?"; answer[6, 0] = "Jupiter."; answer[6, 1] = "Saturn."; answer[6, 2] = "Uranus."; answer[6, 3] = "Neptune."; questiontype[6] = QuestionType.MultipleChoice;
            question[7] = "Where is Neptune's magnetic field generated?"; answer[7, 0] = "In an ocean of hydrogen compounds, rocks, and metals."; answer[7, 1] = "In a layer of metallic hydrogen."; answer[7, 2] = "In an ocean of hydrogen and helium."; answer[7, 3] = "In a liquid metallic core."; questiontype[7] = QuestionType.MultipleChoice;
            question[8] = "Which planet has the most large moons?"; answer[8, 0] = "Jupiter."; answer[8, 1] = "Saturn."; answer[8, 2] = "Uranus."; answer[8, 3] = "Neptune."; questiontype[8] = QuestionType.MultipleChoice;
            question[9] = "Tidal heating on Io causes "; answer[9, 0] = "sulfur volcanoes."; answer[9, 1] = "a subsurface water ocean."; answer[9, 2] = "geysers of water at its south pole."; answer[9, 3] = "tectonic surface features."; questiontype[9] = QuestionType.MultipleChoice;
            question[10] = "Io, Europa, and Ganymede have tidal heating because "; answer[10, 0] = "an orbital resonance keeps their orbits elliptical."; answer[10, 1] = "they are the closest moons to Jupiter."; answer[10, 2] = "an orbital resonance causes the moons to exert tidal forces on each other."; answer[10, 3] = "they are the largest moons in the solar system."; questiontype[10] = QuestionType.MultipleChoice;
            question[11] = "What is the largest moon in the solar system?"; answer[11, 0] = "Ganymede."; answer[11, 1] = "Titan."; answer[11, 2] = "Europa."; answer[11, 3] = "Io."; questiontype[11] = QuestionType.MultipleChoice;
            question[12] = "What is the liquid in Titan's rivers and lakes?"; answer[12, 0] = "Methane and ethane."; answer[12, 1] = "Methane and ammonia."; answer[12, 2] = "Sulfur and ammonia."; answer[12, 3] = "Sulfur."; questiontype[12] = QuestionType.MultipleChoice;
            question[13] = "What is unusual about Triton?"; answer[13, 0] = "It has a backwards orbit."; answer[13, 1] = "It has lakes and rivers."; answer[13, 2] = "It has volcanic activity."; answer[13, 3] = "It has a large axis tilt."; questiontype[13] = QuestionType.MultipleChoice;
            question[14] = "Why are some small jovian planet moons geologically active?"; answer[14, 0] = "Ice is able to deform at lower temperatures than rock."; answer[14, 1] = "Impact cratering melted the interior."; answer[14, 2] = "They have large amounts of radioactive material."; answer[14, 3] = "All of the above."; questiontype[14] = QuestionType.MultipleChoice;
            question[15] = "If Jupiter was the size of a basketball, Earth would be the size of a(n)"; answer[15, 0] = "marble."; answer[15, 1] = "bacterium."; answer[15, 2] = "grain of rice."; answer[15, 3] = "orange."; questiontype[15] = QuestionType.MultipleChoice;
            question[16] = "About how long does it take a spacecraft to go from Earth to Jupiter?"; answer[16, 0] = "Several years."; answer[16, 1] = "A week."; answer[16, 2] = "A year."; answer[16, 3] = "Several decades."; questiontype[16] = QuestionType.MultipleChoice;
            question[17] = "Jovian planets"; answer[17, 0] = "have rings and large numbers of moons."; answer[17, 1] = "all have many moons, but only Saturn has rings."; answer[17, 2] = "have moons, but Uranus and Neptune have only one or two."; answer[17, 3] = "are massive and rotate slowly."; questiontype[17] = QuestionType.MultipleChoice;
            question[18] = "What is the structure of Jupiter like?"; answer[18, 0] = "Gaseous on the outside, then liquid hydrogen, " + Environment.NewLine +
                "more dense metallic hydrogen, rocky core."; answer[18, 1] = "Rocky core, thin atmosphere."; answer[18, 2] = "Rocky core, thick atmosphere."; answer[18, 3] = "Gaseous on the outside, then liquid hydrogen, then helium, " + Environment.NewLine +
                "then the other elements."; questiontype[18] = QuestionType.MultipleChoice;
            question[19] = "What are the most common elements in the atmospheres of the jovian planets?"; answer[19, 0] = "Hydrogen and helium."; answer[19, 1] = "Water."; answer[19, 2] = "Oxygen and nitrogen."; answer[19, 3] = "Oxygen and carbon."; questiontype[19] = QuestionType.MultipleChoice;
            question[20] = "What are the most common hydrogen compounds in the atmospheres of the " + Environment.NewLine +
                "jovian planets?"; answer[20, 0] = "Water (H2O), methane (CH4), ammonia (NH3)."; answer[20, 1] = "Water and carbon dioxide (CO2)."; answer[20, 2] = "Water and carbon monoxide (CO)."; answer[20, 3] = "Sulfur dioxide (SO2) and propane (C3H8)."; questiontype[20] = QuestionType.MultipleChoice;
            question[21] = "Since there are a lot of flammable gases on Jupiter, such as methane and " + Environment.NewLine +
                "propane,if you lit a match, would Jupiter burn? "; answer[21, 0] = "No"; answer[21, 1] = "Yes"; answer[21, 2] = ""; answer[21, 3] = ""; questiontype[21] = QuestionType.TrueOrFalse;
            question[22] = "Convection circulates gases from deep in Jupiter's atmosphere to the " + Environment.NewLine +
                "top, where they"; answer[22, 0] = "condense and make clouds."; answer[22, 1] = "condense and make rain."; answer[22, 2] = "escape into space."; answer[22, 3] = "form compounds."; questiontype[22] = QuestionType.MultipleChoice;
            //question[23] = ""; answer[23, 0] = ""; answer[23, 1] = ""; answer[23, 2] = ""; answer[23, 3] = ""; questiontype[23] = QuestionType.MultipleChoice;
            //question[24] = ""; answer[24, 0] = ""; answer[24, 1] = ""; answer[24, 2] = ""; answer[24, 3] = ""; questiontype[24] = QuestionType.MultipleChoice;
            //question[25] = ""; answer[25, 0] = ""; answer[25, 1] = ""; answer[25, 2] = ""; answer[25, 3] = ""; questiontype[25] = QuestionType.MultipleChoice;
            //question[26] = ""; answer[26, 0] = ""; answer[26, 1] = ""; answer[26, 2] = ""; answer[26, 3] = ""; questiontype[26] = QuestionType.MultipleChoice;
            //question[27] = ""; answer[27, 0] = ""; answer[27, 1] = ""; answer[27, 2] = ""; answer[27, 3] = ""; questiontype[27] = QuestionType.MultipleChoice;
            //question[28] = ""; answer[28, 0] = ""; answer[28, 1] = ""; answer[28, 2] = ""; answer[28, 3] = ""; questiontype[28] = QuestionType.MultipleChoice;
            //question[29] = ""; answer[29, 0] = ""; answer[29, 1] = ""; answer[29, 2] = ""; answer[29, 3] = ""; questiontype[29] = QuestionType.MultipleChoice;
            //question[30] = ""; answer[30, 0] = ""; answer[30, 1] = ""; answer[30, 2] = ""; answer[30, 3] = ""; questiontype[30] = QuestionType.MultipleChoice;
            //question[31] = ""; answer[31, 0] = ""; answer[31, 1] = ""; answer[31, 2] = ""; answer[31, 3] = ""; questiontype[31] = QuestionType.MultipleChoice;
            //question[32] = ""; answer[32, 0] = ""; answer[32, 1] = ""; answer[32, 2] = ""; answer[32, 3] = ""; questiontype[32] = QuestionType.MultipleChoice;
            //question[33] = ""; answer[33, 0] = ""; answer[33, 1] = ""; answer[33, 2] = ""; answer[33, 3] = ""; questiontype[33] = QuestionType.MultipleChoice;
            //question[34] = ""; answer[34, 0] = ""; answer[34, 1] = ""; answer[34, 2] = ""; answer[34, 3] = ""; questiontype[34] = QuestionType.MultipleChoice;
            //question[35] = ""; answer[35, 0] = ""; answer[35, 1] = ""; answer[35, 2] = ""; answer[35, 3] = ""; questiontype[35] = QuestionType.MultipleChoice;
            //question[36] = ""; answer[36, 0] = ""; answer[36, 1] = ""; answer[36, 2] = ""; answer[36, 3] = ""; questiontype[36] = QuestionType.MultipleChoice;
            //question[37] = ""; answer[37, 0] = ""; answer[37, 1] = ""; answer[37, 2] = ""; answer[37, 3] = ""; questiontype[37] = QuestionType.MultipleChoice;
            //question[38] = ""; answer[38, 0] = ""; answer[38, 1] = ""; answer[38, 2] = ""; answer[38, 3] = ""; questiontype[38] = QuestionType.MultipleChoice;
            //question[39] = ""; answer[39, 0] = ""; answer[39, 1] = ""; answer[39, 2] = ""; answer[39, 3] = ""; questiontype[39] = QuestionType.MultipleChoice;

            order = new int[numberOfQuestions];
            randomOrder = new int[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                order[i] = i;
                randomOrder[i] = i;
            }
        }

        public Chapter8()
        {
            Setup_Questions();
        }

        public void Randomize_Questions()
        {
            Random rnd = new Random();
            randomOrder = order.OrderBy(x => rnd.Next()).ToArray();
        }

        public string Get_Question(int index)
        {
            if (index >= 0 && index < numberOfQuestions)
            {
                return question[index];
            }

            return string.Empty;
        }

        public string Get_Answer(int index)
        {
            if (index >= 0 && index < numberOfQuestions)
            {
                return answer[index, 0];
            }

            return string.Empty;
        }

        public int Get_Number_Of_Questions()
        {
            return numberOfQuestions;
        }

        public int Get_Minutes()
        {
            return minutes;
        }

        public int Get_Seconds()
        {
            return seconds;
        }
    }
}
