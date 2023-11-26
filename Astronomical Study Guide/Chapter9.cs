using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Study_Guide
{
    class Chapter9
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
            numberOfQuestions = 37;
            numberOfAnswers = 4;
            question = new string[numberOfQuestions];
            answer = new string[numberOfQuestions, numberOfAnswers];
            questiontype = new QuestionType[numberOfQuestions];
            mastered = new bool[numberOfQuestions];

            question[0] = "How big is the largest asteroid?"; answer[0, 0] = "About 1000 km in diameter."; answer[0, 1] = "About 3000 km in diameter."; answer[0, 2] = "About 10,000 km in diameter."; answer[0, 3] = "About 300 km in diameter."; questiontype[0] = QuestionType.MultipleChoice;
            question[1] = "What is the average distance between asteroids in the asteroid belt?"; answer[1, 0] = "About 1,000,000 km."; answer[1, 1] = "About 100,000 km."; answer[1, 2] = "About 10,000 km."; answer[1, 3] = "About 1,000 km."; questiontype[1] = QuestionType.MultipleChoice;
            question[2] = "Why didn't the material in the asteroid belt form a planet?"; answer[2, 0] = "Orbital resonances with Jupiter disrupted the orbits of the " + Environment.NewLine +
                "asteroids and prevented them from forming a planet."; answer[2, 1] = "There was not enough material there to gravitationally accrete into a planet."; answer[2, 2] = "The asteroids were too far apart to run into each other frequently " + Environment.NewLine +
                "enough to form a planet."; answer[2, 3] = "A planet formed early in the solar system and was broken apart by a " + Environment.NewLine +
                "giant impact."; questiontype[2] = QuestionType.MultipleChoice;
            question[3] = "What are the Trojan asteroids?"; answer[3, 0] = "They are asteroids in the 1:1 resonance with Jupiter in Jupiter's orbit."; answer[3, 1] = "They are particularly large asteroids in the main asteroid belt."; answer[3, 2] = "They are asteroids whose orbits cross the orbits or Earth and Mars."; answer[3, 3] = "They are asteroids in any resonance with Jupiter."; questiontype[3] = QuestionType.MultipleChoice;
            question[4] = "Why are most meteorites found in Antarctica?"; answer[4, 0] = "Meteorites are dark and easy to spot against the ice in Antarctica."; answer[4, 1] = "Meteorites melt coming through the atmosphere and usually only survive if " + Environment.NewLine +
                "quickly refrozen by the cold temperatures of Antarctica."; answer[4, 2] = "Because of the slower rotational speed of Earth near the poles, meteorites " + Environment.NewLine +
                "are more likely to survive atmospheric entry near the poles."; answer[4, 3] = "The orbits of meteoroids and the tilt Earth's axis make them more likely to " + Environment.NewLine +
                "impact near the poles."; questiontype[4] = QuestionType.MultipleChoice;
            question[5] = "What are the most common type of meteorite?"; answer[5, 0] = "Stony primitive meteorites."; answer[5, 1] = "Carbon-rich primitive meteorites."; answer[5, 2] = "Metal-rich processed meteorites."; answer[5, 3] = "Rocky processed meteorites."; questiontype[5] = QuestionType.MultipleChoice;
            question[6] = "What is the orientation of a comet's plasma tail?"; answer[6, 0] = "The plasma tail extends from the nucleus in the " + Environment.NewLine +
                "opposite direction of the Sun."; answer[6, 1] = "The plasma tail extends from the nucleus in the opposite " + Environment.NewLine +
                "direction of the comet's motion."; answer[6, 2] = "The plasma tail extends from the nucleus both away from " + Environment.NewLine +
                "the Sun and away from the orbital motion of the comet. "; answer[6, 3] = "The plasma tail extends from the nucleus toward the Sun."; questiontype[6] = QuestionType.MultipleChoice;
            question[7] = "What produces meteor showers?"; answer[7, 0] = "Meteor showers are caused by the passage of Earth " + Environment.NewLine +
                "through the debris left by a comet in its orbit."; answer[7, 1] = "Meteor showers are caused by the passage of Earth " + Environment.NewLine +
                "through the dust tail of a comet."; answer[7, 2] = "Meteor showers are caused by the passage of Earth " + Environment.NewLine +
                "through a debris cloud from an asteroid collision."; answer[7, 3] = "Meteor showers are produced by a large meteoroid " + Environment.NewLine +
                "breaking up as it enters the atmosphere."; questiontype[7] = QuestionType.MultipleChoice;
            question[8] = "Comet nuclei are often described as"; answer[8, 0] = "Dirty Snowballs."; answer[8, 1] = "Giant Snowballs."; answer[8, 2] = "Dirty Ice Cubes."; answer[8, 3] = "Giant Ice Cubes."; questiontype[8] = QuestionType.MultipleChoice;
            question[9] = "Where do the Kuiper belt comets come from?"; answer[9, 0] = "They formed in the Kuiper belt."; answer[9, 1] = "They formed in the asteroid belt and were scattered out by Jupiter."; answer[9, 2] = "They formed among the jovian planets and were scattered " + Environment.NewLine +
                "out by Jupiter."; answer[9, 3] = "They formed among the jovian planets and were pushed " + Environment.NewLine +
                "out by the solar wind."; questiontype[9] = QuestionType.MultipleChoice;
            question[10] = "What is comet SL9?"; answer[10, 0] = "It is a comet that was seen crashing into Jupiter."; answer[10, 1] = "It is the largest comet in the Oort cloud."; answer[10, 2] = "It is the comet that was studied by the Deep Impact " + Environment.NewLine +
                "spacecraft, which sent an impactor into its nucleus."; answer[10, 3] = "It is the comet that hit Earth 65 million years ago " + Environment.NewLine +
                "leading to a mass extinction."; questiontype[10] = QuestionType.MultipleChoice;
            question[11] = "Which of the following is not evidence for a large impact on Earth" + Environment.NewLine +
                "65 million years ago?"; answer[11, 0] = "Globally distributed meteorites with a radiometric age of 65 million years."; answer[11, 1] = "Enhanced levels of elements common in meteorites in " + Environment.NewLine +
                "65 million year old sediment layers."; answer[11, 2] = "Soot in sediment layers indicating global fires."; answer[11, 3] = "Solidified rock droplets in the sediment layers."; questiontype[11] = QuestionType.MultipleChoice;
            question[12] = "How large was the object that caused the Tunguska event?"; answer[12, 0] = "About 40 meters across."; answer[12, 1] = "About 100 meters across."; answer[12, 2] = "About 400 meters across."; answer[12, 3] = "About 10 meters across."; questiontype[12] = QuestionType.MultipleChoice;
            question[13] = "How often does an impactor large enough to cause a tsunamis and " + Environment.NewLine +
                "widespread devastation strike Earth?"; answer[13, 0] = "About once in a million years."; answer[13, 1] = "About once in 1000 years."; answer[13, 2] = "About once in a hundred million years."; answer[13, 3] = "About once in a billion years."; questiontype[13] = QuestionType.MultipleChoice;
            question[14] = "How would the impact history on Earth have been different if Jupiter " + Environment.NewLine +
                "did not exist?"; answer[14, 0] = "There would be more impacts from comets and fewer from asteroids."; answer[14, 1] = "There would be no significant difference."; answer[14, 2] = "There would be more impacts from comets and asteroids."; answer[14, 3] = "There would be fewer impacts from comets and asteroids."; questiontype[14] = QuestionType.MultipleChoice;
            question[15] = "Asteroids "; answer[15, 0] = "are rocky, with a wide range of sizes, up to " + Environment.NewLine +
                "hundreds of miles in diameter."; answer[15, 1] = "are rocky and small–typically the size of a grain of " + Environment.NewLine +
                "rice or a marble."; answer[15, 2] = "are made mostly of metals."; answer[15, 3] = "are mostly found in the inner solar system."; questiontype[15] = QuestionType.MultipleChoice;
            question[16] = "If you keep pushing a person on a swing with little pushes, at just " + Environment.NewLine +
                "the right frequency, they will swing very high. This is an example of"; answer[16, 0] = "resonance."; answer[16, 1] = "Newton's second law."; answer[16, 2] = "Newton's first law."; answer[16, 3] = "energy conservation."; questiontype[16] = QuestionType.MultipleChoice;
            question[17] = "Orbits of asteroids in the asteroid belt "; answer[17, 0] = "All of the above."; answer[17, 1] = "are mostly between Mars and Jupiter."; answer[17, 2] = "are grouped into patterns by resonances with Jupiter."; answer[17, 3] = "are mostly inside the frost line."; questiontype[17] = QuestionType.MultipleChoice;
            question[18] = "What is the best way to find the density of an asteroid?"; answer[18, 0] = "Find an asteroid with a moon and use Kepler's 3rd law."; answer[18, 1] = "Look at its spectrum."; answer[18, 2] = "Study a sample of its matter."; answer[18, 3] = "None of the above."; questiontype[18] = QuestionType.MultipleChoice;
            question[19] = "Most meteorites come from "; answer[19, 0] = "asteroids."; answer[19, 1] = "the Moon and Mars."; answer[19, 2] = "destroyed planets."; answer[19, 3] = "stars."; questiontype[19] = QuestionType.MultipleChoice;
            question[20] = "A typical meteorite is "; answer[20, 0] = "About the size of a pea or grain of rice, and makes a " + Environment.NewLine +
                "bright streak in the sky as it burns up."; answer[20, 1] = "about the size of a pea or grain of rice, and is invisible " + Environment.NewLine +
                "when it lands."; answer[20, 2] = "about the size of a house, and makes a crater when it " + Environment.NewLine +
                "impacts Earth's surface."; answer[20, 3] = "about the size of a large city, and causes widespread " + Environment.NewLine +
                "destruction when it impacts Earth's surface."; questiontype[20] = QuestionType.MultipleChoice;
            question[21] = "A meteor "; answer[21, 0] = "is a flash of light made by a falling meteorite and " + Environment.NewLine +
                "is usually seen at night."; answer[21, 1] = " is a flash of light made by a falling meteorite."; answer[21, 2] = "is usually seen at night."; answer[21, 3] = "is a fragment of asteroid or comet that reaches Earth's surface."; questiontype[21] = QuestionType.MultipleChoice;
            question[22] = "Primitive meteorites "; answer[22, 0] = "are approximately 4.6 billion years old and give us clues " + Environment.NewLine +
                "to what the early solar system was like."; answer[22, 1] = "are approximately 4.6 billion years old."; answer[22, 2] = "give us clues to what the early solar system was like."; answer[22, 3] = "represent samples of shattered worlds."; questiontype[22] = QuestionType.MultipleChoice;
            question[23] = "Processed meteorites "; answer[23, 0] = "come from a parent body that was large enough to develop " + Environment.NewLine +
                "a core and mantle and may be metallic or rocky."; answer[23, 1] = "come from a parent body that was large enough to develop a core and mantle."; answer[23, 2] = "may be metallic or rocky."; answer[23, 3] = "are meteorites that have been altered in a lab for study."; questiontype[23] = QuestionType.MultipleChoice;
            question[24] = "Comets "; answer[24, 0] = "formed from planetesimals in the outer part of the " + Environment.NewLine +
                "early solar system."; answer[24, 1] = "formed from planetesimals in the inner part of the " + Environment.NewLine +
                "early solar system."; answer[24, 2] = "orbit the Sun and return time after time, for billions " + Environment.NewLine +
                "of years."; answer[24, 3] = "have a single tail that streams out straight behind " + Environment.NewLine +
                "them."; questiontype[24] = QuestionType.MultipleChoice;
            question[25] = "The nucleus of a comet"; answer[25, 0] = "is made of dust and ice, like a dirty snowball and " + Environment.NewLine +
                "turns to gas when the comet nears the Sun."; answer[25, 1] = " is made of dust and ice, like a dirty snowball."; answer[25, 2] = "turns to gas when the comet nears the Sun."; answer[25, 3] = "is made of rock."; questiontype[25] = QuestionType.MultipleChoice;
            question[26] = "If Earth passed through the tail of a comet, what would happen?"; answer[26, 0] = "A meteor shower would occur."; answer[26, 1] = "People would die from the gasses such as " + Environment.NewLine +
                "methane and ammonia."; answer[26, 2] = "Earth would be bombarded by large impactors."; answer[26, 3] = "Earth might be knocked out of its orbit or its axis " + Environment.NewLine +
                "might get tilted."; questiontype[26] = QuestionType.MultipleChoice;
            question[27] = "Why is there a meteor shower every year on Aug. 10, 11, and 12?"; answer[27, 0] = "Earth passes through the orbit of a comet and " + Environment.NewLine +
                "hits the remaining debris at the same time each year."; answer[27, 1] = "Meteorites only enter the solar system on certain dates."; answer[27, 2] = "Meteorites often have 1 year orbital periods."; answer[27, 3] = "None of the above."; questiontype[27] = QuestionType.MultipleChoice;
            question[28] = "What is plasma (in astronomy)?"; answer[28, 0] = "An ionized or charged gas made when atoms " + Environment.NewLine +
                "lose one or more electrons."; answer[28, 1] = "An element commonly found in space."; answer[28, 2] = "A constituent of blood."; answer[28, 3] = "Another name for the solar wind."; questiontype[28] = QuestionType.MultipleChoice;
            question[29] = "Why do comet tails always point away from the Sun?"; answer[29, 0] = "The solar wind blows them away from the Sun."; answer[29, 1] = "They are left behind as the comet moves."; answer[29, 2] = "Newton's third law: If the comet goes one way, the " + Environment.NewLine +
                "tail must go the other way."; answer[29, 3] = "They don't; this is just a perspective effect of how " + Environment.NewLine +
                "we view them."; questiontype[29] = QuestionType.MultipleChoice;
            question[30] = "Every time a comet gets near the Sun, some of its material streams away in " + Environment.NewLine +
                "the tail. Shouldn't all comets be gone?"; answer[30, 0] = "No, not that much material vaporizes."; answer[30, 1] = "Yes."; answer[30, 2] = "Yes, but there are more comets stored in Deep " + Environment.NewLine +
                "Freeze beyond Pluto."; answer[30, 3] = "Not yet, but they will all be gone sometime in the " + Environment.NewLine +
                "near future."; questiontype[30] = QuestionType.MultipleChoice;
            question[31] = "What is the Reservoir of cold comets beyond Pluto called?"; answer[31, 0] = "The Kuiper belt."; answer[31, 1] = "The Oort cloud."; answer[31, 2] = "The extrasolar system source."; answer[31, 3] = "The comet reservoir."; questiontype[31] = QuestionType.MultipleChoice;
            question[32] = "What do astronomers think Pluto is?"; answer[32, 0] = "A large Kuiper belt comet."; answer[32, 1] = "A major planet."; answer[32, 2] = "An escaped moon of Neptune."; answer[32, 3] = "An asteroid."; questiontype[32] = QuestionType.MultipleChoice;
            question[33] = "Why do some comets come from far out in space and from all different directions " + Environment.NewLine +
                "(i.e., not in the plane of the solar system)?"; answer[33, 0] = "They come from a giant spherical cloud called the Oort cloud."; answer[33, 1] = "They come from other solar systems."; answer[33, 2] = "They come from nebulae in interstellar space."; answer[33, 3] = "They come from the Kuiper belt when a comet is flung " + Environment.NewLine +
                "out by Neptune's gravity."; questiontype[33] = QuestionType.MultipleChoice;
            question[34] = "About how often is it estimated that an asteroid or comet impacts Earth " + Environment.NewLine +
                "with sufficient energy to cause mass extinction?"; answer[34, 0] = "Once every hundred million years."; answer[34, 1] = "Once a millennium."; answer[34, 2] = "Once every million years."; answer[34, 3] = "Once in Earth's history."; questiontype[34] = QuestionType.MultipleChoice;
            question[35] = "Surprising discovery? - A small asteroid that orbits within the asteroid " + Environment.NewLine +
                "belt has an active volcano."; answer[35, 0] = "Implausible. Asteroids are too small to be " + Environment.NewLine +
                "geologically active now."; answer[35, 1] = "Implausible. Only planets, not moons or asteroids, " + Environment.NewLine +
                "have volcanoes."; answer[35, 2] = "Plausible. Several small objects in the solar system " + Environment.NewLine +
                "have active volcanoes."; answer[35, 3] = "Plausible. Several asteroids are known to be " + Environment.NewLine +
                "composed of basaltic material (lava)."; questiontype[35] = QuestionType.MultipleChoice;
            question[36] = "Surprising discovery? - A mission to Pluto finds that it has lakes of " + Environment.NewLine +
                "liquid water on its surface."; answer[36, 0] = "Implausible. Water would be frozen at Pluto's " + Environment.NewLine +
                "temperature, and we know of no heating sources " + Environment.NewLine +
                "that would cause the water to melt."; answer[36, 1] = "Implausible. Pluto is mostly made of rock and metals, " + Environment.NewLine +
                "not water."; answer[36, 2] = "Plausible. Other icy bodies at great distances from the " + Environment.NewLine +
                "Sun may also have liquid water on their surfaces."; answer[36, 3] = "Plausible. Studies of Pluto's surface show a long, narrow " + Environment.NewLine +
                "feature that looks like a lake."; questiontype[36] = QuestionType.MultipleChoice;
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

        public Chapter9()
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
