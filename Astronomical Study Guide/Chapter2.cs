using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Study_Guide
{
    class Chapter2
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
            numberOfQuestions = 54;
            numberOfAnswers = 4;
            question = new string[numberOfQuestions];
            answer = new string[numberOfQuestions, numberOfAnswers];
            questiontype = new QuestionType[numberOfQuestions];
            mastered = new bool[numberOfQuestions];

            question[0] = "The ecliptic is "; answer[0, 0] = "the path of the Sun on the celestial sphere and the projection of Earth's orbit onto the celestial sphere."; answer[0, 1] = "the projection of Earth's equator onto the celestial sphere."; answer[0, 2] = "the path of the Sun on the celestial sphere."; answer[0, 3] = "the projection of Earth's orbit onto the celestial sphere."; questiontype[0] = QuestionType.MultipleChoice;
            question[1] = "The meridian is "; answer[1, 0] = "the boundary between the eastern and western halves of your local sky."; answer[1, 1] = "the projection of Earth's equator onto the celestial sphere."; answer[1, 2] = "the point in your local sky directly above you."; answer[1, 3] = "the boundary between the northern and southern halves of your local sky."; questiontype[1] = QuestionType.MultipleChoice;
            question[2] = "All of the following are points on your local sky. Which one does not move on " + Environment.NewLine +
                "the celestial sphere over the course of a day?"; answer[2, 0] = "The north celestial pole."; answer[2, 1] = "The zenith."; answer[2, 2] = "Altitude of 30 degrees, direction due north."; answer[2, 3] = "None of the above."; questiontype[2] = QuestionType.MultipleChoice;
            question[3] = "If the Sun and a constellation are at the same location in your local sky, then " + Environment.NewLine +
                "that constellation is "; answer[3, 0] = "visible at a different time of year and part of the zodiac."; answer[3, 1] = "not a constellation that can be observed at night."; answer[3, 2] = "visible at a different time of year."; answer[3, 3] = "part of the zodiac."; questiontype[3] = QuestionType.MultipleChoice;
            question[4] = "A star near the north celestial pole, observed from the northern hemisphere "; answer[4, 0] = "will never rise or set and is called a circumpolar star."; answer[4, 1] = "will never rise or set."; answer[4, 2] = "is called a circumpolar star."; answer[4, 3] = "is part of the zodiac."; questiontype[4] = QuestionType.MultipleChoice;
            question[5] = "In order to see all of the celestial sphere at night, one must "; answer[5, 0] = "observe from different longitudes."; answer[5, 1] = "observe from different latitudes."; answer[5, 2] = "observe at different times of year."; answer[5, 3] = "observe at different times of year and from different latitudes."; questiontype[5] = QuestionType.MultipleChoice;
            question[6] = "On the (northern) spring equinox the Sun "; answer[6, 0] = "all of the above"; answer[6, 1] = "is on the celestial equator."; answer[6, 2] = "is moving from the southern part of the celestial sphere to the northern part of the celestial sphere."; answer[6, 3] = "is on the ecliptic."; questiontype[6] = QuestionType.MultipleChoice;
            question[7] = "The Sun is at its most southern position on the celestial sphere "; answer[7, 0] = "on the winter solstice (December 21)."; answer[7, 1] = "on the summer solstice (June 21)."; answer[7, 2] = "on the equinoxes."; answer[7, 3] = "The Sun does not move north and south on the celestial sphere."; questiontype[7] = QuestionType.MultipleChoice;
            question[8] = "If you are at a latitude of 23.5 degrees north, when will the Sun be directly overhead?"; answer[8, 0] = "At noon on the summer solstice (June 21)."; answer[8, 1] = "At noon on the winter solstice (December 21)."; answer[8, 2] = "At noon on the equinoxes."; answer[8, 3] = "Every day at noon."; questiontype[8] = QuestionType.MultipleChoice;
            question[9] = "Which lists the various motions of Earth in increasing order of the period (duration) " + Environment.NewLine +
                "of the motion?"; answer[9, 0] = "Rotation, revolution, precession."; answer[9, 1] = "Revolution, rotation, precession."; answer[9, 2] = "Rotation, precession, revolution."; answer[9, 3] = "Revolution, precession, rotation."; questiontype[9] = QuestionType.MultipleChoice;
            question[10] = "Which of the following is not changed by the precession of Earth's axis?"; answer[10, 0] = "The location of the North Celestial Pole in your local sky."; answer[10, 1] = "The location of the North Celestial Pole relative to the stars."; answer[10, 2] = "The location of the celestial equator relative to the stars."; answer[10, 3] = "The location of the celestial equator in your local sky."; questiontype[10] = QuestionType.MultipleChoice;
            question[11] = "When the phase of the Moon is full, "; answer[11, 0] = "the Moon and Sun are on opposite sides of Earth."; answer[11, 1] = "the Moon is further from Earth than normal."; answer[11, 2] = "the Moon and Sun are on the same side of Earth."; answer[11, 3] = "the Moon and Earth are on opposites sides of the Sun."; questiontype[11] = QuestionType.MultipleChoice;
            question[12] = "When the phase of the Moon is gibbous, "; answer[12, 0] = "the Moon is closer to Full Moon than to New Moon and more than half of the " + Environment.NewLine +
                "visible face of the Moon is illuminated."; answer[12, 1] = "the Moon is closer to New Moon than to Full Moon and more than half of the " + Environment.NewLine +
                "visible face of the Moon is illuminated."; answer[12, 2] = "the Moon is closer to New Moon than to Full Moon."; answer[12, 3] = "more than half of the visible face of the Moon is illuminated."; questiontype[12] = QuestionType.MultipleChoice;
            question[13] = "What time does the first quarter moon rise?"; answer[13, 0] = "noon"; answer[13, 1] = "sunrise"; answer[13, 2] = "sunset"; answer[13, 3] = "midnight"; questiontype[13] = QuestionType.MultipleChoice;
            question[14] = "When the Moon passes through Earth's shadow, this is called "; answer[14, 0] = "a lunar eclipse."; answer[14, 1] = "a solar eclipse. "; answer[14, 2] = "either a lunar eclipse or a solar eclipse, depending " + Environment.NewLine +
                "on the distance between the Moon and Earth."; answer[14, 3] = "either a lunar eclipse or a solar eclipse, depending " + Environment.NewLine +
                "on the phase of the Moon."; questiontype[14] = QuestionType.MultipleChoice;
            question[15] = "Which of the following results in an annular solar eclipse?"; answer[15, 0] = "Earth passes behind the Moon's umbra."; answer[15, 1] = "The Moon passes through Earth's umbra."; answer[15, 2] = "Earth passes through the Moon's umbra."; answer[15, 3] = "Earth passes through the Moon's penumbra."; questiontype[15] = QuestionType.MultipleChoice;
            question[16] = "Lunar eclipses do not occur every month because "; answer[16, 0] = "the orbit of the Moon is tilted relative to the ecliptic."; answer[16, 1] = "the orbit of the Moon is tilted relative to Earth's equator."; answer[16, 2] = "a lunar eclipse can only occur at the equinoxes."; answer[16, 3] = "Lunar eclipses do occur every month."; questiontype[16] = QuestionType.MultipleChoice;
            question[17] = "The Saros cycle describes "; answer[17, 0] = "the 18+ year cycle of lunar and solar eclipses."; answer[17, 1] = "the 6 month period between eclipse seasons."; answer[17, 2] = "the cycle of retrograde motion of the planets."; answer[17, 3] = "the period between total solar eclipses."; questiontype[17] = QuestionType.MultipleChoice;
            question[18] = "What causes the apparent retrograde motion of Mars?"; answer[18, 0] = "When Earth passes Mars it appears to change its motion " + Environment.NewLine +
                "relative to the background stars."; answer[18, 1] = "Mars reverses its orbital motion when it is furthest " + Environment.NewLine +
                "from the Sun."; answer[18, 2] = "Because Earth orbits faster than Mars, Mars always " +
                "seems to move in the opposite direction as the Moon " + Environment.NewLine +
                "and the Sun."; answer[18, 3] = "Mars orbits the Sun in the opposite direction as Earth."; questiontype[18] = QuestionType.MultipleChoice;
            question[19] = "Stellar parallax is "; answer[19, 0] = "the changing position of nearby stars compared " + Environment.NewLine +
                "to background stars as Earth orbits the Sun."; answer[19, 1] = "the changing position of stars relative to each other " + Environment.NewLine +
                "due to their different speeds in the Milky Way."; answer[19, 2] = "the changing position of nearby stars compared to " + Environment.NewLine +
                "background stars as Earth's axis precesses."; answer[19, 3] = "the changing position of stars relative to each other " + Environment.NewLine +
                "as the Sun orbits the center of the Milky Way."; questiontype[19] = QuestionType.MultipleChoice;
            question[20] = "The sky is divided into 88 zones called "; answer[20, 0] = "constellations."; answer[20, 1] = "degrees."; answer[20, 2] = "tropics."; answer[20, 3] = "signs."; questiontype[20] = QuestionType.MultipleChoice;
            question[21] = "A map of the entire sky, as seen from Earth, is called "; answer[21, 0] = "the celestial sphere."; answer[21, 1] = "a meridian."; answer[21, 2] = "a sky finder."; answer[21, 3] = "the celestial directory."; questiontype[21] = QuestionType.MultipleChoice;
            question[22] = "Objects are located on the celestial sphere in units of "; answer[22, 0] = "degrees."; answer[22, 1] = "miles."; answer[22, 2] = "parsecs."; answer[22, 3] = "kilometers."; questiontype[22] = QuestionType.MultipleChoice;
            question[23] = "The angular size of your fist, held at arms length, is about"; answer[23, 0] = "10 degrees."; answer[23, 1] = "5 degrees."; answer[23, 2] = "1 degree."; answer[23, 3] = "20 degrees."; questiontype[23] = QuestionType.MultipleChoice;
            question[24] = "The apparent size of the moon in the sky is about "; answer[24, 0] = "½ degree."; answer[24, 1] = "5 degrees."; answer[24, 2] = "10 degrees."; answer[24, 3] = "20 degrees."; questiontype[24] = QuestionType.MultipleChoice;
            question[25] = "When an astronomer describes the altitude of something in the local sky, he or she means "; answer[25, 0] = "how high something is in the sky, in units of degrees."; answer[25, 1] = "how high something is in the sky, in units of miles."; answer[25, 2] = "how high something is in the sky, in units of kilometers."; answer[25, 3] = "the direction toward something– north, south, east, or west."; questiontype[25] = QuestionType.MultipleChoice;
            question[26] = "When an astronomer describes the azimuth of something in the local sky, he or she means "; answer[26, 0] = "the direction toward something– north, south, east, or west."; answer[26, 1] = "how high something is in the sky, in units of degrees."; answer[26, 2] = "how high something is in the sky, in units of kilometers."; answer[26, 3] = "how high something is in the sky, in units of miles."; questiontype[26] = QuestionType.MultipleChoice;
            question[27] = "Directly above Earth's north pole on the celestial sphere is "; answer[27, 0] = "a star called Polaris."; answer[27, 1] = "the brightest star in the sky."; answer[27, 2] = "the Zenith."; answer[27, 3] = "the Big Dipper."; questiontype[27] = QuestionType.MultipleChoice;
            question[28] = "As seen from North America, stars near Polaris in the sky "; answer[28, 0] = "never set."; answer[28, 1] = "are seen only in summer."; answer[28, 2] = "are seen only in winter."; answer[28, 3] = "are in the Big Dipper."; questiontype[28] = QuestionType.MultipleChoice;
            question[29] = "What makes Polaris a special star?"; answer[29, 0] = "It is near the axis about which the sky turns and " + Environment.NewLine +
                "Its azimuth (direction) is always due north."; answer[29, 1] = "It is near the axis about which the sky turns."; answer[29, 2] = "Its azimuth (direction) is always due north."; answer[29, 3] = "It is always directly overhead, no matter where you are."; questiontype[29] = QuestionType.MultipleChoice;
            question[30] = "Why are different stars seen in different seasons?"; answer[30, 0] = "because as Earth orbits the Sun, we see the " + Environment.NewLine +
                "Sun in front of different constellations "; answer[30, 1] = "because of Earth's axis tilt"; answer[30, 2] = "because stars move during the year"; answer[30, 3] = "because of precession"; questiontype[30] = QuestionType.MultipleChoice;
            question[31] = "During the year, the Sun appears in front of different groups of stars. What " + Environment.NewLine +
                "are these called? "; answer[31, 0] = "the constellations of the zodiac"; answer[31, 1] = "circumpolar stars"; answer[31, 2] = "circumsolar stars"; answer[31, 3] = "solstice stars"; questiontype[31] = QuestionType.MultipleChoice;
            question[32] = "Why are the Moon and planets seen only in the constellations of the zodiac?"; answer[32, 0] = "the planets all orbit in nearly the same plane, and " + Environment.NewLine +
                "the zodiacal constellations are in that plane "; answer[32, 1] = "the planets all revolve in the same direction around the Sun"; answer[32, 2] = "the constellations in the zodiac are the oldest, and " + Environment.NewLine +
                "the planets have been known from ancient times"; answer[32, 3] = "none of the above"; questiontype[32] = QuestionType.MultipleChoice;
            question[33] = "When might you see the planet Jupiter in the Big Dipper?"; answer[33, 0] = "never"; answer[33, 1] = "summer"; answer[33, 2] = "winter"; answer[33, 3] = "only after midnight"; questiontype[33] = QuestionType.MultipleChoice;
            question[34] = "When is the Sun directly overhead at noon?"; answer[34, 0] = "never"; answer[34, 1] = "July 21"; answer[34, 2] = "June 21"; answer[34, 3] = "March 21"; questiontype[34] = QuestionType.MultipleChoice;
            question[35] = "When it is summer in the United States, in Australia it is "; answer[35, 0] = "winter."; answer[35, 1] = "summer."; answer[35, 2] = "spring."; answer[35, 3] = "fall."; questiontype[35] = QuestionType.MultipleChoice;
            question[36] = "In summer, in the northern hemisphere, what is the Sun's daily motion?"; answer[36, 0] = "Rises north of east, sets north of west."; answer[36, 1] = "Rises in the east, sets in the west."; answer[36, 2] = "Rises in the west, sets in the east."; answer[36, 3] = "Rises north of east, sets south of west."; questiontype[36] = QuestionType.MultipleChoice;
            question[37] = "What causes the seasons?"; answer[37, 0] = "In summer, the Sun is up for more hours and the Sun climbs " + Environment.NewLine +
                "higher in the sky so its rays hit the ground more directly."; answer[37, 1] = "In summer, the Sun is up for more hours."; answer[37, 2] = "In summer, the Sun climbs higher in the sky so its rays " + Environment.NewLine +
                "hit the ground more directly."; answer[37, 3] = "In summer, the tilt of Earth's axis means that one " + Environment.NewLine +
                "part of Earth is closer to the Sun."; questiontype[37] = QuestionType.MultipleChoice;
            question[38] = "If the tilt of Earth's axis to its orbital plane was 40 degrees, instead of 23 ½, " + Environment.NewLine +
                "but its distance from the Sun remained the same, what would happen to the seasons?"; answer[38, 0] = "They would become more extreme–winter colder and summer warmer."; answer[38, 1] = "They wouldn't change much."; answer[38, 2] = "They would become less extreme–winter and summer would be more alike."; answer[38, 3] = "All of Earth would get colder."; questiontype[38] = QuestionType.MultipleChoice;
            question[39] = "It takes a pot of soup a few minutes to heat up on a stove. Approximately how long " + Environment.NewLine +
                "does it take for the Sun to warm up Earth in spring or summer?"; answer[39, 0] = "Several months."; answer[39, 1] = "Several hours."; answer[39, 2] = "About a full day."; answer[39, 3] = "Two weeks."; questiontype[39] = QuestionType.MultipleChoice;
            question[40] = "The full moon rises at approximately "; answer[40, 0] = "sunset."; answer[40, 1] = "midnight."; answer[40, 2] = "sunrise."; answer[40, 3] = "It rises at different times during the year."; questiontype[40] = QuestionType.MultipleChoice;
            question[41] = "If you were on the Moon, Earth would "; answer[41, 0] = "show phases opposite to the Moon (when it is " + Environment.NewLine +
                "full Moon it is new Earth, etc.)."; answer[41, 1] = "show phases the same as the Moon (when it is full Moon it is full Earth, etc.)."; answer[41, 2] = "show no phases."; answer[41, 3] = "show the same phase throughout."; questiontype[41] = QuestionType.MultipleChoice;
            question[42] = "Suppose that the Moon was a cube, but everything else was the same–it " + Environment.NewLine +
                "kept one side facing Earth as it orbited. What would its phases be like?"; answer[42, 0] = "It would only show new and full phases."; answer[42, 1] = "The same as now, except square: crescent square, half-square, full square, etc."; answer[42, 2] = "The phases would be just like now."; answer[42, 3] = "It would not have phases."; questiontype[42] = QuestionType.MultipleChoice;
            question[43] = "Why have more people seen an eclipse of the Moon than an eclipse of the Sun?"; answer[43, 0] = "The shadow of the Moon is smaller than the shadow of Earth and " + Environment.NewLine +
                "anyone on the night side of Earth can see a total eclipse of the Moon."; answer[43, 1] = "Anyone on the night side of Earth can see a total eclipse of the Moon."; answer[43, 2] = "Anyone on the day side of Earth can see a total solar eclipse."; answer[43, 3] = "The shadow of the Moon is smaller than the shadow of Earth."; questiontype[43] = QuestionType.MultipleChoice;
            question[44] = "The observation of retrograde motion "; answer[44, 0] = "could be explained by either the geocentric or heliocentric model."; answer[44, 1] = "proved that the geocentric model is correct."; answer[44, 2] = "proved that the heliocentric (sun-centered) model is correct."; answer[44, 3] = "cannot be explained by any model."; questiontype[44] = QuestionType.MultipleChoice;
            question[45] = "Why didn't the Greek astronomer Hipparchos observe the parallax of stars?"; answer[45, 0] = "It couldn't be detected without a telescope."; answer[45, 1] = "He believed that Earth didn't move, so there was no parallax."; answer[45, 2] = "He did; he just didn't know what it meant."; answer[45, 3] = "Not all stars show parallax."; questiontype[45] = QuestionType.MultipleChoice;
            question[46] = "If our solar system were located at the exact opposite side of the galaxy, would " + Environment.NewLine +
                "we be able to see the Andromeda Galaxy?"; answer[46, 0] = "Yes, but it would appear in a different constellation."; answer[46, 1] = "Yes, but we would see the other side of Andromeda."; answer[46, 2] = "No, Andromeda would then be so far away that its light " + Environment.NewLine +
                "would be too weak to detect."; answer[46, 3] = "No, the stars in our galaxy would obscure Andromeda."; questiontype[46] = QuestionType.MultipleChoice;
            question[47] = "What makes the North Star special?"; answer[47, 0] = "It lies close to the north celestial pole and is therefore very useful for navigation."; answer[47, 1] = "It was the first star to be cataloged by ancient astronomers."; answer[47, 2] = "It is the brightest star in the entire sky."; answer[47, 3] = "It is visible from both the northern and southern hemispheres."; questiontype[47] = QuestionType.MultipleChoice;
            question[48] = "If you had a very fast spaceship, you could travel to the celestial sphere in about " + Environment.NewLine +
                "a month."; answer[48, 0] = "This statement doesn't make sense because the " + Environment.NewLine +
                "celestial sphere is not a physical object."; answer[48, 1] = "No, the celestial sphere moves away from us at the speed of " + Environment.NewLine +
                "light so we can never catch up with it."; answer[48, 2] = "No, the celestial sphere is so far away that, even moving at " + Environment.NewLine +
                "close to the speed of light, it would take tens of thousands of " + Environment.NewLine +
                "years to reach."; answer[48, 3] = "Yes, but once such a spacecraft crosses the celestial sphere it can never return."; questiontype[48] = QuestionType.MultipleChoice;
            question[49] = "I live in the United States, and during my first trip to Argentina " + Environment.NewLine +
                "I saw many constellations that I'd never seen before."; answer[49, 0] = "Yes, Argentina's southern location affords us a different " + Environment.NewLine +
                "view of the night sky from what is visible in the U.S."; answer[49, 1] = "Yes, the skies in Argentina are notable for their clarity, " + Environment.NewLine +
                "therefore you can see many more stars there than in the U.S."; answer[49, 2] = "No, the constellations are upside down so they appear " + Environment.NewLine +
                "different but they are actually the same."; answer[49, 3] = "This might be true if the visit occurred in the winter when " + Environment.NewLine +
                "different constellations are visible than in the summer."; questiontype[49] = QuestionType.MultipleChoice;
            question[50] = "Last night I saw Mars move westward through the sky in its apparent retrograde " + Environment.NewLine +
                "motion."; answer[50, 0] = "No, apparent retrograde motion is only noticeable over " + Environment.NewLine +
                "many nights, not a single night."; answer[50, 1] = "No, because Mars lies further from the Sun than Earth, it " + Environment.NewLine +
                "does not undergo retrograde motion."; answer[50, 2] = "Yes, this occurs during certain times of the year when Earth " + Environment.NewLine +
                "overtakes Mars in its orbit."; answer[50, 3] = "All planets (and stars) move westward because of Earth's " + Environment.NewLine +
                "rotation, so this is not unusual."; questiontype[50] = QuestionType.MultipleChoice;
            question[51] = "If Earth's orbit were a perfect circle, we would not have seasons."; answer[51, 0] = "False, the seasons are due to the tilt of Earth's axis, not " + Environment.NewLine +
                "its distance from the Sun."; answer[51, 1] = "True, because Earth would be at the same distance from the " + Environment.NewLine +
                "Sun throughout its orbit, there would be no summer or winter."; answer[51, 2] = "True, it is the deviations from a circular orbit that create the seasons."; answer[51, 3] = "False, whether circular or not, the seasons depend on the " + Environment.NewLine +
                "precession of Earth's axis as it orbits the Sun."; questiontype[51] = QuestionType.MultipleChoice;
            question[52] = "Because of precession, someday it will be summer everywhere on Earth at the same time."; answer[52, 0] = "No, precession only changes the direction in which " + Environment.NewLine +
                "the North Pole points, and has nothing to do with the " + Environment.NewLine +
                "seasons."; answer[52, 1] = "Yes, but it would take tens of thousands of years, longer than " + Environment.NewLine +
                "current human history, for this to occur."; answer[52, 2] = "Yes, precession will make summers occur at the same time, " + Environment.NewLine +
                "but in what is now the northern spring and southern fall."; answer[52, 3] = "Yes, precession will naturally circularize Earth's orbit."; questiontype[52] = QuestionType.MultipleChoice;
            question[53] = "If the Moon is setting at 6 A.M., the phase of the Moon must be "; answer[53, 0] = "full."; answer[53, 1] = "new."; answer[53, 2] = "first quarter."; answer[53, 3] = "third quarter."; questiontype[53] = QuestionType.MultipleChoice;
            //question[54] = ""; answer[54, 0] = ""; answer[54, 1] = ""; answer[54, 2] = ""; answer[54, 3] = ""; questiontype[54] = QuestionType.MultipleChoice;
            //question[55] = ""; answer[55, 0] = ""; answer[55, 1] = ""; answer[55, 2] = ""; answer[55, 3] = ""; questiontype[55] = QuestionType.MultipleChoice;
            //question[56] = ""; answer[56, 0] = ""; answer[56, 1] = ""; answer[56, 2] = ""; answer[56, 3] = ""; questiontype[56] = QuestionType.MultipleChoice;
            //question[57] = ""; answer[57, 0] = ""; answer[57, 1] = ""; answer[57, 2] = ""; answer[57, 3] = ""; questiontype[57] = QuestionType.MultipleChoice;
            //question[58] = ""; answer[58, 0] = ""; answer[58, 1] = ""; answer[58, 2] = ""; answer[58, 3] = ""; questiontype[58] = QuestionType.MultipleChoice;
            //question[59] = ""; answer[59, 0] = ""; answer[59, 1] = ""; answer[59, 2] = ""; answer[59, 3] = ""; questiontype[59] = QuestionType.MultipleChoice;

            order = new int[numberOfQuestions];
            randomOrder = new int[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                order[i] = i;
                randomOrder[i] = i;
            }
        }

        public Chapter2()
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
