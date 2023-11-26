using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Study_Guide
{
    class Chapter1
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
            numberOfQuestions = 65;
            numberOfAnswers = 4;
            question = new string[numberOfQuestions];
            answer = new string[numberOfQuestions, numberOfAnswers];
            questiontype = new QuestionType[numberOfQuestions];
            mastered = new bool[numberOfQuestions];

            question[0] = "An Astronomical Unit (AU) is "; answer[0, 0] = "Earth's average distance from the sun."; answer[0, 1] = "Any planet's average distance from the sun."; answer[0, 2] = "Any large astronomical distance."; answer[0, 3] = "One light year."; questiontype[0] = QuestionType.MultipleChoice;
            question[1] = "If we represent the solar system on a scale that allows us to walk from the Sun " + Environment.NewLine +
                "to Pluto in a few minutes, then "; answer[1, 0] = "the planets are marble size or smaller and the nearest stars are a thousands of miles away.";  answer[1, 1] = "the planets are the size of basketballs and the nearest stars are a few miles away."; answer[1, 2] = "the planets are microscopic and the stars are millions of miles away."; answer[1, 3] = "the planets are the size of cue balls and the nearest stars are hundreds of miles away."; questiontype[1] = QuestionType.MultipleChoice;
            question[2] = "A television advertisement claiming that a product is light-years ahead of its " + Environment.NewLine +
                "time does not make sense because "; answer[2, 0] = "it uses light-years to talk about time, but a light-year is a unit of distance."; answer[2, 1] = "light-years can only be used to talk about light. "; answer[2, 2] = "a light-year is an astronomically large unit, so a product could not possibly be so advanced."; answer[2, 3] = "it doesn't specify the number of light-years."; questiontype[2] = QuestionType.MultipleChoice;
            question[3] = "Based on observations of the universal expansion, the age of the universe is about "; answer[3, 0] = "14 billion years."; answer[3, 1] = "14,000 years."; answer[3, 2] = "14 trillion years."; answer[3, 3] = "14 million years."; questiontype[3] = QuestionType.MultipleChoice;
            question[4] = "Earth is always precisely 1 AU from the Sun."; answer[4, 0] = "False"; answer[4, 1] = "True"; questiontype[4] = QuestionType.TrueOrFalse;
            question[5] = "How many galaxies are there in the observable universe?"; answer[5, 0] = "Roughly (within a factor of 10) the same as the number of stars in our galaxy."; answer[5, 1] = "An infinite number."; answer[5, 2] = "About as many as the number of grains of sand on all the beaches on Earth."; answer[5, 3] = "About as many as the number of stars we see in the sky with our naked eyes."; questiontype[5] = QuestionType.MultipleChoice;
            question[6] = "If you could count stars at a rate of about one per second, how long would it take " + Environment.NewLine +
                "to count all the stars in the Milky Way Galaxy?"; answer[6, 0] = "Several thousand years."; answer[6, 1] = "Several weeks."; answer[6, 2] = "Several years."; answer[6, 3] = "Several days."; questiontype[6] = QuestionType.MultipleChoice;
            question[7] = "All of the following statements are true. Which one explains the reason why " + Environment.NewLine +
                "there is not a solar eclipse at every new Moon?"; answer[7, 0] = "The orbital plane of the Moon is tilted by about 5° to the ecliptic plane."; answer[7, 1] = "The Moon rotates synchronously with its revolution about Earth."; answer[7, 2] = "The nodes of the Moon's orbit precess with an 18-year period."; answer[7, 3] = "The sidereal month is shorter than the lunar month."; questiontype[7] = QuestionType.MultipleChoice;
            question[8] = "At approximately what time would a first quarter Moon rise?"; answer[8, 0] = "Noon."; answer[8, 1] = "6 A.M."; answer[8, 2] = "6 P.M."; answer[8, 3] = "9 A.M."; questiontype[8] = QuestionType.MultipleChoice;
            question[9] = "By locating the north celestial pole (NCP) in the sky, how can you determine " + Environment.NewLine +
                "your latitude?"; answer[9, 0] = "The altitude of the NCP is the same as your latitude."; answer[9, 1] = "The altitude of the NCP is your angular distance from the North Pole."; answer[9, 2] = "The azimuth of the NCP is the angular distance from the North Pole."; answer[9, 3] = "The altitude of the NCP is the same as your distance from the North Pole."; questiontype[9] = QuestionType.MultipleChoice;
            question[10] = "If it is midnight in New York, it is  "; answer[10, 0] = "daytime in Sydney, Australia."; answer[10, 1] = "midnight in Sydney, Australia."; answer[10, 2] = "midnight in Los Angeles."; answer[10, 3] = "midday in Rio de Janeiro, Brazil."; questiontype[10] = QuestionType.MultipleChoice;
            question[11] = "If the Moon is rising at midnight, the phase of the Moon must be "; answer[11, 0] = "third quarter."; answer[11, 1] = "first quarter."; answer[11, 2] = "waning crescent."; answer[11, 3] = "waxing crescent."; questiontype[11] = QuestionType.MultipleChoice;
            question[12] = "The Milky Way Galaxy is "; answer[12, 0] = "a disk-shaped collection of more than 100 billion stars, including the Sun."; answer[12, 1] = "the Sun, the planets, and all other objects orbiting the Sun."; answer[12, 2] = "the total of all energy and matter in the universe."; answer[12, 3] = "all the stars visible in the night sky."; questiontype[12] = QuestionType.MultipleChoice;
            question[13] = "Which of the following has the various objects listed in order from smallest " + Environment.NewLine +
                "to largest?"; answer[13, 0] = "the solar system; the Milky Way; the Local Group"; answer[13, 1] = "the Milky Way; the Local Group; the solar system"; answer[13, 2] = "the Local Group; the Milky Way; the solar system"; answer[13, 3] = "the solar system; the Local Group; the Milky Way"; questiontype[13] = QuestionType.MultipleChoice;
            
            question[14] = "Most of the material that makes up Earth and all life on Earth, including " + Environment.NewLine +
                "humans, was formed"; answer[14, 0] = "inside stars that died before Earth formed."; answer[14, 1] = "in the Big Bang."; answer[14, 2] = "inside the Sun."; answer[14, 3] = "in the atmospheres of nearby stars that are still " + Environment.NewLine + "shining and spraying material out into the galaxy."; questiontype[14] = QuestionType.MultipleChoice;
            question[15] = "When we look at the most distant observable objects in the universe, we see them "; answer[15, 0] = "as they were about 14 billion years ago."; answer[15, 1] = "as they were about 4.5 billion years ago."; answer[15, 2] = "as they are now."; answer[15, 3] = "as they were at some time in the past, depending " + Environment.NewLine + "on which direction we are looking."; questiontype[15] = QuestionType.MultipleChoice;
            question[16] = "What is the observable universe?"; answer[16, 0] = "everything out to a distance of about 14 billion light-years from Earth"; answer[16, 1] = "the sum total of all matter and energy"; answer[16, 2] = "all the stars and planets that can be observed with the naked eye"; answer[16, 3] = "the Milky Way Galaxy and its neighboring galaxies"; questiontype[16] = QuestionType.MultipleChoice;
            question[17] = "Which of the following has astronomical distances listed in order from smallest " + Environment.NewLine +
                "to largest?"; answer[17, 0] = "1 AU, the size of the solar system, 1 light-year"; answer[17, 1] = "1 AU, 1 light-year, the size of the solar system"; answer[17, 2] = "1 light-year, 1 AU, the size of the solar system"; answer[17, 3] = "1 light-year, the size of the solar system, 1 AU"; questiontype[17] = QuestionType.MultipleChoice;
            question[18] = "Which of the following distances is approximately equal to the distance from the " + Environment.NewLine +
                "Sun to Earth?"; answer[18, 0] = "8 light minutes"; answer[18, 1] = "1 light-second"; answer[18, 2] = "300,000 km"; answer[18, 3] = "93,000,000 km"; questiontype[18] = QuestionType.MultipleChoice;
            question[19] = "The International Astronomical Union does not classify Pluto as a planet because "; answer[19, 0] = "it has not cleared its orbital neighborhood of other objects."; answer[19, 1] = "it is too far from the Sun to be a planet."; answer[19, 2] = "it is too small to be a planet."; answer[19, 3] = "it's composition is not planetary."; questiontype[19] = QuestionType.MultipleChoice;
            question[20] = "The distance to the nearest star to the Sun is "; answer[20, 0] = "about 4 light-years."; answer[20, 1] = "about 8 light-minutes."; answer[20, 2] = "about 100,000 light-years."; answer[20, 3] = "about 14 billion light-years."; questiontype[20] = QuestionType.MultipleChoice;
            question[21] = "The diameter of the Milky Way is about"; answer[21, 0] = "100,000 light-years."; answer[21, 1] = "4.5 billion light-years."; answer[21, 2] = "3000 light-years."; answer[21, 3] = "100,000 AU."; questiontype[21] = QuestionType.MultipleChoice;
            question[22] = "If the Sun were reduced to the size of a grapefruit, Earth on the same scale " + Environment.NewLine +
                "would be "; answer[22, 0] = "the size of the tip of a ballpoint pen, about 15 meters away from the Sun."; answer[22, 1] = "the size of a marble, about 100 meters away from the Sun."; answer[22, 2] = "the size of a marble, about 15 meters away from the Sun."; answer[22, 3] = "the size of the tip of a ballpoint pen, about 5 meters away from the Sun."; questiontype[22] = QuestionType.MultipleChoice;
            question[23] = "If the age of the universe were compressed to one year, with the Big Bang on " + Environment.NewLine +
                "January 1, about when did the solar system form?"; answer[23, 0] = "in September"; answer[23, 1] = "in January"; answer[23, 2] = "in February"; answer[23, 3] = "in December"; questiontype[23] = QuestionType.MultipleChoice;
            question[24] = "If the age of the universe were compressed to one year, with the Big Bang on " + Environment.NewLine +
                "January 1, about when did the Milky Way Galaxy form?"; answer[24, 0] = "in February"; answer[24, 1] = "in January"; answer[24, 2] = "in September"; answer[24, 3] = "in December"; questiontype[24] = QuestionType.MultipleChoice;
            question[25] = "Which of the following is the general difference between a planet and a star?"; answer[25, 0] = "Stars shine with energy released by nuclear fusion, whereas planets shine primarily wit light reflected from stars."; answer[25, 1] = "Stars are made of gas, and planets are made of rock."; answer[25, 2] = "Stars are found in galaxies but planets are not part of galaxies."; answer[25, 3] = "Stars are stationary, whereas planets orbit stars."; questiontype[25] = QuestionType.MultipleChoice;
            question[26] = "According to current scientific estimates, when did the Big Bang occur?"; answer[26, 0] = "about 14 billion years ago."; answer[26, 1] = "about 20 billion years ago."; answer[26, 2] = "about 4 1/2 billion years ago."; answer[26, 3] = "about 10 billion years ago."; questiontype[26] = QuestionType.MultipleChoice;
            question[27] = "On the cosmic calendar, which compresses the history of the universe into a " + Environment.NewLine +
                "single year, about when did Earth form?"; answer[27, 0] = "In early September."; answer[27, 1] = "In mid-December."; answer[27, 2] = "In June"; answer[27, 3] = "In mid-February."; questiontype[27] = QuestionType.MultipleChoice;
            question[28] = "On the cosmic calendar, which compresses the history of the universe into a " + Environment.NewLine +
                "single year, about when did life arise on earth?"; answer[28, 0] = "In September."; answer[28, 1] = "In mid-December."; answer[28, 2] = "In June."; answer[28, 3] = "Just a few hours before midnight on December 31."; questiontype[28] = QuestionType.MultipleChoice;
            question[29] = "On the cosmic calendar, which compresses the history of the universe into a " + Environment.NewLine +
                "single year, about when did early humans first walk on Earth?"; answer[29, 0] = "Just a few hours before midnight on December 31."; answer[29, 1] = "In September."; answer[29, 2] = "In mid-December."; answer[29, 3] = "In June."; questiontype[29] = QuestionType.MultipleChoice;
            question[30] = "On a scale where the Sun is about the size of a grapefruit and Earth is about " + Environment.NewLine +
                "15 meters away, how far away are the nearest stars besides the Sun?"; answer[30, 0] = "About the distance across the United States."; answer[30, 1] = "About the distance across the state of Delaware."; answer[30, 2] = "About the distance across 50 football fields."; answer[30, 3] = "100 meters."; questiontype[30] = QuestionType.MultipleChoice;
            question[31] = "Put these objects in the correct order, from nearest to farthest from Earth: "; answer[31, 0] = "The Moon, Mars, the Sun, Pluto, the nearest stars."; answer[31, 1] = "The Moon, Mars, the Sun, the nearest stars, Pluto."; answer[31, 2] = "The Moon, the Sun, Mars, Pluto, the nearest stars."; answer[31, 3] = "Mars, the Moon, the Sun, the nearest stars, Pluto."; questiontype[31] = QuestionType.MultipleChoice;
            question[32] = "Put these objects in the correct order, from nearest to farthest from Earth:"; answer[32, 0] = "The Sun, Pluto, Alpha Centauri, the Milky Way, the Andromeda galaxy."; answer[32, 1] = "The Sun, the Milky Way, Alpha Centauri, Pluto, the Andromeda galaxy."; answer[32, 2] = "The Sun, Alpha Centauri, Pluto, the Andromeda galaxy, the Milky Way."; answer[32, 3] = "Pluto, the Sun, Alpha Centauri, the Milky Way, the Andromeda galaxy."; questiontype[32] = QuestionType.MultipleChoice;
            question[33] = "Which is farther, the distance from San Francisco to Los Angeles, or the distance " + Environment.NewLine +
                "from you to the space shuttle if the shuttle passes directly overhead?"; answer[33, 0] = "San Francisco to Los Angeles is farther."; answer[33, 1] = "The space shuttle is farther."; answer[33, 2] = ""; answer[33, 3] = ""; questiontype[33] = QuestionType.TrueOrFalse;
            question[34] = "What is the effect of the expansion of the universe?"; answer[34, 0] = "The galaxies are getting farther apart from each other."; answer[34, 1] = "Each galaxy is getting larger."; answer[34, 2] = "The solar system is getting larger."; answer[34, 3] = "All of the above."; questiontype[34] = QuestionType.MultipleChoice;
            question[35] = "Does the expansion of the universe cause you to expand?"; answer[35, 0] = "No"; answer[35, 1] = "Yes"; answer[35, 2] = ""; answer[35, 3] = ""; questiontype[35] = QuestionType.TrueOrFalse;
            question[36] = "Which of the following is NOT a way in which we move through the universe?"; answer[36, 0] = "The Milky Way orbits the center of the universe."; answer[36, 1] = "Our solar system orbits the center of our galaxy."; answer[36, 2] = "The Earth orbits the Sun."; answer[36, 3] = "The Earth is spinning on its axis."; questiontype[36] = QuestionType.MultipleChoice;
            question[37] = "In a scale model solar system that used a grapefruit to represent the Sun, " + Environment.NewLine +
                "how large would Earth be?"; answer[37, 0] = "The size of the point of a ballpoint pen."; answer[37, 1] = "The size of a marble."; answer[37, 2] = "The size of an orange."; answer[37, 3] = "The size of a bacterium."; questiontype[37] = QuestionType.MultipleChoice;
            question[38] = "In a scale model solar system that used a grapefruit to represent the Sun, how far " + Environment.NewLine +
                "away would Earth be?"; answer[38, 0] = "50 feet."; answer[38, 1] = "6 inches."; answer[38, 2] = "1 foot."; answer[38, 3] = "5 feet."; questiontype[38] = QuestionType.MultipleChoice;
            question[39] = "In a scale model solar system that used a grapefruit to represent the Sun, how far " + Environment.NewLine +
                "away would Pluto–the edge of the solar system–be?"; answer[39, 0] = "2000 feet."; answer[39, 1] = "200 feet."; answer[39, 2] = "100 feet."; answer[39, 3] = "10 miles."; questiontype[39] = QuestionType.MultipleChoice;
            question[40] = "In a scale model solar system that used a grapefruit to represent the Sun, how far " + Environment.NewLine +
                "away should you put another grapefruit to represent Alpha Centauri, the next nearest star?"; answer[40, 0] = "2000 miles."; answer[40, 1] = "10 miles."; answer[40, 2] = "1 mile."; answer[40, 3] = "2000 feet."; questiontype[40] = QuestionType.MultipleChoice;
            question[41] = "At the speed of light, how long would it take to go from Earth to the Sun?"; answer[41, 0] = "About 8 minutes."; answer[41, 1] = "About a minute."; answer[41, 2] = "About a second."; answer[41, 3] = "About a day."; questiontype[41] = QuestionType.MultipleChoice;
            question[42] = "At the speed of light, how long would it take to reach the nearest star, Alpha Centauri?"; answer[42, 0] = "About 4 years."; answer[42, 1] = "About a year."; answer[42, 2] = "About 1,000,000 years."; answer[42, 3] = "About 1,000 years."; questiontype[42] = QuestionType.MultipleChoice;
            question[43] = "About how old is Earth?"; answer[43, 0] = "5 billion years."; answer[43, 1] = "14 billion years."; answer[43, 2] = "1 billion years."; answer[43, 3] = "6000 years."; questiontype[43] = QuestionType.MultipleChoice;
            question[44] = "The Milky Way is moving further away from most other galaxies in the Universe."; answer[44, 0] = "True"; answer[44, 1] = "False"; answer[44, 2] = ""; answer[44, 3] = ""; questiontype[44] = QuestionType.TrueOrFalse;
            question[45] = "Relative to the age of the universe, how old is our solar system? "; answer[45, 0] = "It is about one-third the age of the universe."; answer[45, 1] = "It is between about 5% and 10% as old as the universe."; answer[45, 2] = "It is nearly the same age as the universe."; answer[45, 3] = "It is about 1% as old as the universe."; questiontype[45] = QuestionType.MultipleChoice;
            question[46] = "Which of the following has your address in the correct order? "; answer[46, 0] = "You, Earth, solar system, Milky Way, Local Group, Local Supercluster."; answer[46, 1] = "You, Earth, solar system, Local Group, Milky Way, Local Supercluster."; answer[46, 2] = "You, Earth, solar system, Milky Way, Local Supercluster, Local Group."; answer[46, 3] = "You, Earth, Local Group, Local Supercluster, solar system, Milky Way."; questiontype[46] = QuestionType.MultipleChoice;
            question[47] = "If you represented each star by a grain of sand, how much sand would it take to represent " + Environment.NewLine +
                "all the stars in the universe? "; answer[47, 0] = "More than all the sand on all the beaches on Earth."; answer[47, 1] = "All the sand on Miami Beach."; answer[47, 2] = "All the sand on the beaches in the United States."; answer[47, 3] = "All the sand in a typical playground sandlot."; questiontype[47] = QuestionType.MultipleChoice;
            question[48] = "On the 1-to-10 billion scale, about how far is it to the nearest stars besides " + Environment.NewLine +
                "the Sun?"; answer[48, 0] = "4,400 kilometers"; answer[48, 1] = "400 kilometers"; answer[48, 2] = "44,000 kilometers"; answer[48, 3] = "440,000 kilometers"; questiontype[48] = QuestionType.MultipleChoice;
            question[49] = "How long does it take the Earth to complete one orbit around the Sun?"; answer[49, 0] = "One year."; answer[49, 1] = "One Month."; answer[49, 2] = "One week."; answer[49, 3] = "One day."; questiontype[49] = QuestionType.MultipleChoice;
            question[50] = "On a cosmic calendar, in which the history of the universe is compressed " + Environment.NewLine +
                "into one year, how long is the average human life span? "; answer[50, 0] = "0.2 seconds."; answer[50, 1] = "0.2 milliseconds."; answer[50, 2] = "2 seconds."; answer[50, 3] = "2 minutes."; questiontype[50] = QuestionType.MultipleChoice;
            question[51] = "What is the Sun mainly made of?"; answer[51, 0] = "Hydrogen and helium."; answer[51, 1] = "Oxygen and carbon."; answer[51, 2] = "Carbon and nitrogen."; answer[51, 3] = "Hydrogen and oxygen."; questiontype[51] = QuestionType.MultipleChoice;
            question[52] = "When we look at an object that is 1,000 light-years away we see it "; answer[52, 0] = "as it was 1,000 years ago."; answer[52, 1] = "as it was 1,000 light-years ago."; answer[52, 2] = "as it is right now, but it appears 1,000 times dimmer."; answer[52, 3] = "looking just the same as our ancestors would have seen it " + Environment.NewLine +
                "1,000 years ago."; questiontype[52] = QuestionType.MultipleChoice;
            question[53] = "On a cosmic calendar, in which the history of the universe is compressed " + Environment.NewLine +
                "into 1 year, when did the dinosaurs become extinct? "; answer[53, 0] = "In late December."; answer[53, 1] = "In late September."; answer[53, 2] = "In late October."; answer[53, 3] = "In late November."; questiontype[53] = QuestionType.MultipleChoice;
            question[54] = "Which of the following is NOT a general difference between a planet and a star?"; answer[54, 0] = "All planets are made of rock and all stars are made of gas."; answer[54, 1] = "Planets are dimmer than stars."; answer[54, 2] = "Planets orbit stars, while stars orbit the center of the galaxy."; answer[54, 3] = "Planets are smaller than stars."; questiontype[54] = QuestionType.MultipleChoice;
            question[55] = "Which of the following statements does not use the term light-year in an " + Environment.NewLine +
                "appropriate way? "; answer[55, 0] = "It will take me light-years to complete this homework assignment."; answer[55, 1] = "It's about 4 light-years from here to Alpha Centauri."; answer[55, 2] = "A light-year is about 10 trillion kilometers."; answer[55, 3] = "The Milky Way Galaxy is about 100,000 light-years in diameter."; questiontype[55] = QuestionType.MultipleChoice;
            question[56] = "At approximately what time would a full Moon be on your meridian?"; answer[56, 0] = "Midnight."; answer[56, 1] = "6 P.M."; answer[56, 2] = "Noon."; answer[56, 3] = "6 A.M."; questiontype[56] = QuestionType.MultipleChoice;
            question[57] = "Which of the following statements about the Moon is true?"; answer[57, 0] = "The Moon's distance from Earth varies during its orbit."; answer[57, 1] = "If you see a full Moon from North America, someone " + Environment.NewLine +
                "in South America would see a new Moon."; answer[57, 2] = "The Moon goes through a cycle of phases because it always " + Environment.NewLine +
                "has the same side facing Earth. "; answer[57, 3] = "The side of the Moon facing away from Earth is in perpetual darkness."; questiontype[57] = QuestionType.MultipleChoice;
            question[58] = "We describe a position on Earth's surface by stating its "; answer[58, 0] = "latitude and longitude."; answer[58, 1] = "altitude and direction."; answer[58, 2] = "altitude and azimuth."; answer[58, 3] = "latitude and direction."; questiontype[58] = QuestionType.MultipleChoice;
            question[59] = "Why is it summer in the Northern Hemisphere when it is winter in the Southern Hemisphere? "; answer[59, 0] = "The Northern Hemisphere is tilted toward the Sun and " + Environment.NewLine +
                "receives more direct sunlight. "; answer[59, 1] = "The Northern Hemisphere is tilted away from the Sun and " + Environment.NewLine +
                "receives more indirect sunlight. "; answer[59, 2] = "The Northern Hemisphere is on top of Earth and " + Environment.NewLine +
                "therefore receives more sunlight. "; answer[59, 3] = "The Northern Hemisphere is closer to the Sun than " + Environment.NewLine +
                "the Southern Hemisphere. "; questiontype[59] = QuestionType.MultipleChoice;
            question[60] = "What is the ecliptic? "; answer[60, 0] = "The path the Sun appears to trace around the celestial sphere each year."; answer[60, 1] = "The path traced by the Moon's shadow on Earth during a solar eclipse."; answer[60, 2] = "The Sun's daily path from east to west in our sky."; answer[60, 3] = "A half-circle extending from your horizon due north, " + Environment.NewLine +
                "through your zenith, to your horizon due south."; questiontype[60] = QuestionType.MultipleChoice;
            question[61] = "Which of the following correctly describes the meridian in your local sky?"; answer[61, 0] = "A half-circle extending from your horizon due north, " + Environment.NewLine +
                "through your zenith, to your horizon due south."; answer[61, 1] = "A half-circle extending from your horizon due east, " + Environment.NewLine +
                "through your zenith, to your horizon due west."; answer[61, 2] = "The point directly over your head."; answer[61, 3] = "A half-circle extending from your horizon due east, " + Environment.NewLine +
                "through the north celestial pole, to your horizon due west."; questiontype[61] = QuestionType.MultipleChoice;
            question[62] = "Which of the following statements is true?"; answer[62, 0] = "Both the Northern and Southern hemispheres receive the same amount " + Environment.NewLine +
                "of sunlight on the equinoxes and the Northern Hemisphere receives the most direct sunlight on the summer solstice."; answer[62, 1] = "Both the Northern and Southern hemispheres receive the same amount " + Environment.NewLine +
                "of sunlight on the equinoxes."; answer[62, 2] = "The Northern Hemisphere receives the most direct sunlight " + Environment.NewLine +
                "on the summer solstice."; answer[62, 3] = "The Southern Hemisphere receives the most direct sunlight on " + Environment.NewLine +
                "the summer solstice. "; questiontype[62] = QuestionType.MultipleChoice;
            question[63] = "How many stars can you see with your naked eye on a clear, moonless night " + Environment.NewLine +
                "from a dark location?"; answer[63, 0] = "A few thousand."; answer[63, 1] = "Fewer than a thousand."; answer[63, 2] = "About ten thousand."; answer[63, 3] = "About a hundred thousand."; questiontype[63] = QuestionType.MultipleChoice;
            question[64] = "Which of the following statements about constellations is false?"; answer[64, 0] = "Most constellations will be unrecognizable hundreds of years from now."; answer[64, 1] = "Some constellations can be seen in both the winter and summer."; answer[64, 2] = "Some constellations can be seen from both the Northern and Southern hemispheres."; answer[64, 3] = "It is possible to see all the constellations from Earth's equator."; questiontype[64] = QuestionType.MultipleChoice;
            //question[65] = ""; answer[65, 0] = ""; answer[65, 1] = ""; answer[65, 2] = ""; answer[65, 3] = ""; questiontype[65] = QuestionType.MultipleChoice;
            //question[66] = ""; answer[66, 0] = ""; answer[66, 1] = ""; answer[66, 2] = ""; answer[66, 3] = ""; questiontype[66] = QuestionType.MultipleChoice;
            //question[67] = ""; answer[67, 0] = ""; answer[67, 1] = ""; answer[67, 2] = ""; answer[67, 3] = ""; questiontype[67] = QuestionType.MultipleChoice;
            //question[68] = ""; answer[68, 0] = ""; answer[68, 1] = ""; answer[68, 2] = ""; answer[68, 3] = ""; questiontype[68] = QuestionType.MultipleChoice;
            //question[69] = ""; answer[69, 0] = ""; answer[69, 1] = ""; answer[69, 2] = ""; answer[69, 3] = ""; questiontype[69] = QuestionType.MultipleChoice;
            //question[70] = ""; answer[70, 0] = ""; answer[70, 1] = ""; answer[70, 2] = ""; answer[70, 3] = ""; questiontype[70] = QuestionType.MultipleChoice;
            //question[71] = ""; answer[71, 0] = ""; answer[71, 1] = ""; answer[71, 2] = ""; answer[71, 3] = ""; questiontype[71] = QuestionType.MultipleChoice;
            //question[72] = ""; answer[72, 0] = ""; answer[72, 1] = ""; answer[72, 2] = ""; answer[72, 3] = ""; questiontype[72] = QuestionType.MultipleChoice;
            //question[73] = ""; answer[73, 0] = ""; answer[73, 1] = ""; answer[73, 2] = ""; answer[73, 3] = ""; questiontype[73] = QuestionType.MultipleChoice;
            //question[74] = ""; answer[74, 0] = ""; answer[74, 1] = ""; answer[74, 2] = ""; answer[74, 3] = ""; questiontype[74] = QuestionType.MultipleChoice;
            //question[75] = ""; answer[75, 0] = ""; answer[75, 1] = ""; answer[75, 2] = ""; answer[75, 3] = ""; questiontype[75] = QuestionType.MultipleChoice;
            //question[76] = ""; answer[76, 0] = ""; answer[76, 1] = ""; answer[76, 2] = ""; answer[76, 3] = ""; questiontype[76] = QuestionType.MultipleChoice;
            //question[77] = ""; answer[77, 0] = ""; answer[77, 1] = ""; answer[77, 2] = ""; answer[77, 3] = ""; questiontype[77] = QuestionType.MultipleChoice;
            //question[78] = ""; answer[78, 0] = ""; answer[78, 1] = ""; answer[78, 2] = ""; answer[78, 3] = ""; questiontype[78] = QuestionType.MultipleChoice;
            //question[79] = ""; answer[79, 0] = ""; answer[79, 1] = ""; answer[79, 2] = ""; answer[79, 3] = ""; questiontype[79] = QuestionType.MultipleChoice;

            order = new int[numberOfQuestions];
            randomOrder = new int[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                order[i] = i;
                randomOrder[i] = i;
            }
        }

        public Chapter1()
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
