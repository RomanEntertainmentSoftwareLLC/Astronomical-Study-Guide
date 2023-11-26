using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Study_Guide
{
    class Chapter3
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
            numberOfQuestions = 49;
            numberOfAnswers = 4;
            question = new string[numberOfQuestions];
            answer = new string[numberOfQuestions, numberOfAnswers];
            questiontype = new QuestionType[numberOfQuestions];
            mastered = new bool[numberOfQuestions];

            question[0] = "Scientific thinking is "; answer[0, 0] = "all of the above."; answer[0, 1] = "making predictions about future events based on " + Environment.NewLine +
                "past observations and experiences."; answer[0, 2] = "a gradual process of learning how the world works."; answer[0, 3] = "a willingness to give up preconceived notions if " + Environment.NewLine +
                "those ideas are inconsistent with an experiment or observation. "; questiontype[0] = QuestionType.MultipleChoice;
            question[1] = "Which of the following is not an example of measurements of ancient astronomers?"; answer[1, 0] = "All of the above were measurements made by " + Environment.NewLine +
                "ancient astronomers."; answer[1, 1] = "Marking the day of summer solstice."; answer[1, 2] = "Measuring the 18.6 year cycle of lunar phases due to precession of its orbit."; answer[1, 3] = "Measuring the orientation of the crescent Moon."; questiontype[1] = QuestionType.MultipleChoice;
            question[2] = "Which is longer, a solar year or a lunar year?"; answer[2, 0] = "A solar year, because a lunar year is 12 lunar months " + Environment.NewLine +
                "that are 29–30 days long each, for a total of 354–355 " + Environment.NewLine +
                "days."; answer[2, 1] = "A lunar year, because it is based on 13 months that are 29–30 " + Environment.NewLine +
                "days long, which is longer than 365 days."; answer[2, 2] = "A lunar year, because it is based on the time between total " + Environment.NewLine +
                "lunar eclipses, which is longer than 365 days."; answer[2, 3] = "A solar year, because a lunar year is based on 13 months " + Environment.NewLine +
                "that are 28 days long, which is 364 days."; questiontype[2] = QuestionType.MultipleChoice;
            question[3] = "What does the 19-year Metonic cycle describe?"; answer[3, 0] = "The time it takes for phases of the Moon to repeat on the same dates."; answer[3, 1] = "The time it takes for eclipses to occur on the same dates."; answer[3, 2] = "The time it takes for Earth's axis to precess."; answer[3, 3] = "The time it takes for a series of lunar and solar eclipses to " + Environment.NewLine +
                "repeat, but not on exactly on the same dates."; questiontype[3] = QuestionType.MultipleChoice;
            question[4] = "How did Ptolemy's model differ from Aristotle's model of the universe?"; answer[4, 0] = "Ptolemy's model had the planets moving in smaller " + Environment.NewLine +
                "circles attached to the larger spheres."; answer[4, 1] = "Ptolemy's model placed the Sun at the center rather than Earth."; answer[4, 2] = "Ptolemy's model involved spheres that were not perfectly circular."; answer[4, 3] = "Ptolemy's model had a different ordering of spheres than Aristotle's."; questiontype[4] = QuestionType.MultipleChoice;
            question[5] = "How was the great library of Alexandria destroyed?"; answer[5, 0] = "It was destroyed deliberately by people in the 5th century A.D."; answer[5, 1] = "It was destroyed accidentally in a great fire in the 4th century A.D."; answer[5, 2] = "It was destroyed when the Nile flooded in the 5th century A.D."; answer[5, 3] = "It was abandoned after the death of Alexander the Great, and " + Environment.NewLine +
                "gradually fell into disrepair over a period of several centuries."; questiontype[5] = QuestionType.MultipleChoice;
            question[6] = "Why didn't scientific thinkers immediately accept the Copernican model of " + Environment.NewLine +
                "the solar system?"; answer[6, 0] = "Copernicus's model did not make noticeably better predictions than the Earth-centered " + Environment.NewLine +
                "model and they were reluctant to throw out the Earth-centered model because it had been " + Environment.NewLine +
                "around for so many years."; answer[6, 1] = "Copernicus's model did not make noticeably better predictions than the Earth-centered model."; answer[6, 2] = "They were reluctant to throw out the Earth-centered model " + Environment.NewLine +
                "because it had been around for so many years."; answer[6, 3] = "They had irrefutable evidence that the Earth-centered model was correct."; questiontype[6] = QuestionType.MultipleChoice;
            question[7] = "Who observed a nova in 1572, showing that there could be changes in the realm of " + Environment.NewLine +
                "the heavens?"; answer[7, 0] = "Tycho Brahe"; answer[7, 1] = "Johannes Kepler"; answer[7, 2] = "Galileo Galilei"; answer[7, 3] = "Nicolas Copernicus"; questiontype[7] = QuestionType.MultipleChoice;
            question[8] = "Which of the following is not a contribution made by Tycho Brahe to the " + Environment.NewLine +
                "Copernican Revolution?"; answer[8, 0] = "He measured the parallax of stars, showing that the Earth " + Environment.NewLine +
                "orbits the Sun."; answer[8, 1] = "He measured the parallax of a supernova and showed that it was " + Environment.NewLine +
                "further away than the Moon."; answer[8, 2] = "He measured the parallax of a comet and showed that it " + Environment.NewLine +
                "was further away than the Moon."; answer[8, 3] = "He measured the positions of the planets with unprecedented " + Environment.NewLine +
                "accuracy, making it possible for Kepler to determine their orbits."; questiontype[8] = QuestionType.MultipleChoice;
            question[9] = "Which of the following is not one of Kepler's laws of planetary motion?"; answer[9, 0] = "The rotation of a planet is always aligned with its " + Environment.NewLine +
                "orbital motion around the Sun."; answer[9, 1] = "The orbit of each planet around the Sun is an ellipse " + Environment.NewLine +
                "with the Sun at one focus."; answer[9, 2] = "As a planet orbits the Sun it sweeps out equal areas in " + Environment.NewLine +
                "equal times."; answer[9, 3] = "Planets with larger orbits orbit the Sun at slower average " + Environment.NewLine +
                "speeds than planets with smaller orbits."; questiontype[9] = QuestionType.MultipleChoice;
            question[10] = "Which of the following parts of an ellipse is a measure of its shape?"; answer[10, 0] = "The eccentricity."; answer[10, 1] = "The semi-major axis."; answer[10, 2] = "The stellar parallax."; answer[10, 3] = "The focus."; questiontype[10] = QuestionType.MultipleChoice;
            question[11] = "Which of the following was not an observation made by Galileo supporting " + Environment.NewLine +
                "the Sun-centered model?"; answer[11, 0] = "He measured the parallax of a comet."; answer[11, 1] = "He observed objects orbiting Jupiter."; answer[11, 2] = "He observed the phases of Venus."; answer[11, 3] = "He observed mountains on the Moon."; questiontype[11] = QuestionType.MultipleChoice;
            question[12] = "A scientific model "; answer[12, 0] = "uses math and logic to describe and predict the " + Environment.NewLine +
                "behavior of a real-world system."; answer[12, 1] = "is a small physical representation of a real-world system."; answer[12, 2] = "is a scientist who is photographed for advertisements."; answer[12, 3] = "must be completely accurate or it is considered pseudoscience."; questiontype[12] = QuestionType.MultipleChoice;
            question[13] = "The concept of a scientific model comes from"; answer[13, 0] = "Greek philosophers."; answer[13, 1] = "Galileo Galilei."; answer[13, 2] = "Johannes Kepler."; answer[13, 3] = "Nicolas Copernicus."; questiontype[13] = QuestionType.MultipleChoice;
            question[14] = "If an experiment or observation contradicts a scientific theory, then "; answer[14, 0] = "the theory must be revised to account for the new " + Environment.NewLine +
                "data, or discarded."; answer[14, 1] = "it must not have been a scientific theory, but " + Environment.NewLine +
                "pseudoscience."; answer[14, 2] = "the theory is still considered correct as long as the vast " + Environment.NewLine +
                "majority of experiments still agree with the theory."; answer[14, 3] = "the experiment or observation must be wrong, because a " + Environment.NewLine +
                "theory cannot be contradicted by any measurement."; questiontype[14] = QuestionType.MultipleChoice;
            question[15] = "Which of the following is not a hallmark of science?"; answer[15, 0] = "A scientific theory is built on logic and common sense to " + Environment.NewLine +
                "explain observed phenomena."; answer[15, 1] = "Science seeks explanations for observable phenomena using " + Environment.NewLine +
                "natural causes."; answer[15, 2] = "Science makes progress by testing models that explain " + Environment.NewLine +
                "observations as simply as possible."; answer[15, 3] = "A scientific model makes testable predictions about natural " + Environment.NewLine +
                "phenomena and is revised or abandoned if the predictions do " + Environment.NewLine +
                "not agree with observations."; questiontype[15] = QuestionType.MultipleChoice;
            question[16] = "Which of the following is an astrological prediction?"; answer[16, 0] = "When Saturn enters a particular constellation, " + Environment.NewLine +
                "the weather will improve."; answer[16, 1] = "Venus and Mars will be nearly aligned on a particular date."; answer[16, 2] = "The Moon will eclipse the Sun at a particular time."; answer[16, 3] = "All of the above."; questiontype[16] = QuestionType.MultipleChoice;
            question[17] = "Astrology is "; answer[17, 0] = "not a scientific enterprise because it does not make " + Environment.NewLine +
                "testable predictions."; answer[17, 1] = "not a scientific enterprise because scientists have " + Environment.NewLine +
                "overwhelmingly voted against it in favor of astronomy."; answer[17, 2] = "a scientific study of the effects of the Sun and other " + Environment.NewLine +
                "celestial objects on the Earth and people."; answer[17, 3] = "a scientific study of human behavior."; questiontype[17] = QuestionType.MultipleChoice;
            question[18] = "When was Earth known to be circular and its circumference measured?"; answer[18, 0] = "In ancient Greece."; answer[18, 1] = "From the earliest times."; answer[18, 2] = "At the start of the Renaissance."; answer[18, 3] = "In the early 17th century."; questiontype[18] = QuestionType.MultipleChoice;
            question[19] = "In what ways do most people employ scientific thinking in everyday life?"; answer[19, 0] = "They observe the world and notice patterns and " +
                "they use trial and error–experiments – to test ideas."; answer[19, 1] = "They use trial and error–experiments – to test ideas."; answer[19, 2] = "They observe the world and notice patterns."; answer[19, 3] = "They predict things before they happen."; questiontype[19] = QuestionType.MultipleChoice;
            question[20] = "What characterizes a scientific explanation?"; answer[20, 0] = "It is based on observations and it is tested through " + Environment.NewLine +
                "prediction and experiments."; answer[20, 1] = "It is based on observations."; answer[20, 2] = "It is tested through prediction and experiments."; answer[20, 3] = "It is based on the ideas of the smartest people."; questiontype[20] = QuestionType.MultipleChoice;
            question[21] = "What is the difference between the word theory as used in everyday speech, " + Environment.NewLine +
                "and the word theory as used in science?"; answer[21, 0] = "All of the above."; answer[21, 1] = "A scientific theory must be thoroughly tested, while " + Environment.NewLine +
                "an everyday theory doesn't."; answer[21, 2] = "A scientific theory must be discarded if it fails to " + Environment.NewLine +
                "explain what is observed in any experiment, while an everyday theory doesn't."; answer[21, 3] = "A regular theory is more of a hypothesis than a " + Environment.NewLine +
                "proven explanation."; questiontype[21] = QuestionType.MultipleChoice;
            question[22] = "What method or processes do scientists use when they are doing science?"; answer[22, 0] = "All of the above."; answer[22, 1] = "Doing an experiment or collecting data to test the hypothesis."; answer[22, 2] = "Suggesting a hypothesis, which explains what has been " + Environment.NewLine +
                "seen already and predicts something not yet seen."; answer[22, 3] = "Observing the world; looking for patterns that can be clues to " + Environment.NewLine +
                "underlying laws."; questiontype[22] = QuestionType.MultipleChoice;
            question[23] = "If scientists skip a step in the scientific method–for instance, intuitively " + Environment.NewLine +
                "guessing the answer even before doing the experiment–what happens?"; answer[23, 0] = "They go back later and do the steps they didn't do and other scientists repeat the experiment."; answer[23, 1] = "They go back later and do the steps they didn't do."; answer[23, 2] = "Other scientists repeat the experiment."; answer[23, 3] = "Real scientists never skip steps."; questiontype[23] = QuestionType.MultipleChoice;
            question[24] = "Do you think that the scientific method involves much creativity?"; answer[24, 0] = "Yes"; answer[24, 1] = "No"; answer[24, 2] = ""; answer[24, 3] = ""; questiontype[24] = QuestionType.TrueOrFalse;
            question[25] = "Do you think that science is a system of beliefs?"; answer[25, 0] = "No"; answer[25, 1] = "Yes"; answer[25, 2] = ""; answer[25, 3] = ""; questiontype[25] = QuestionType.TrueOrFalse;
            question[26] = "What is special about scientific knowledge, compared to other ways of knowing?"; answer[26, 0] = "All of the above."; answer[26, 1] = "It has gone through a process of prediction and testing."; answer[26, 2] = "It is based on data."; answer[26, 3] = "Explanations are based on natural causes."; questiontype[26] = QuestionType.MultipleChoice;
            question[27] = "What is pseudoscience?"; answer[27, 0] = "All of the above."; answer[27, 1] = "Something that usually doesn't really work, or doesn't work the way claimed."; answer[27, 2] = "Something that often uses scientific words but not the " + Environment.NewLine +
                "method of science"; answer[27, 3] = "Something that may want the respectability of science but " + Environment.NewLine +
                "does not actually use the methods of science."; questiontype[27] = QuestionType.MultipleChoice;
            question[28] = "What are some of the common characteristics of pseudoscience?"; answer[28, 0] = "All of the above."; answer[28, 1] = "Uses scientific-sounding jargon incorrectly (e.g., energy flows….)."; answer[28, 2] = "If it fails, there is always an excuse–the theory is not discarded."; answer[28, 3] = "It is based on postdiction not prediction. It explains after the fact."; questiontype[28] = QuestionType.MultipleChoice;
            question[29] = "Whose suggestion that the Sun is the center of the solar system was first taken seriously by many people?"; answer[29, 0] = "Copernicus"; answer[29, 1] = "Tycho"; answer[29, 2] = "Kepler"; answer[29, 3] = "Galileo"; questiontype[29] = QuestionType.MultipleChoice;
            question[30] = "What did Tycho do that advanced astronomy significantly?"; answer[30, 0] = "He made more accurate observations than anyone before him."; answer[30, 1] = "He created the Sun centered model."; answer[30, 2] = "He thought of the idea of circles moving on circles (epicycles) to explain planetary motion."; answer[30, 3] = "He realized that orbits didn't have to be circles, they could be ellipses."; questiontype[30] = QuestionType.MultipleChoice;
            question[31] = "Johannes Kepler"; answer[31, 0] = "All of the above."; answer[31, 1] = "Thought he heard the Music of the Spheres."; answer[31, 2] = "Discovered the relationship between orbital period and a " + Environment.NewLine +
                "planets distance from the Sun."; answer[31, 3] = "Found that planets don't orbit at constant velocity–they speed " + Environment.NewLine +
                "up when nearer the Sun."; questiontype[31] = QuestionType.MultipleChoice;
            question[32] = "Why do many scientists consider Galileo the originator of modern science?"; answer[32, 0] = "He emphasized how important it is to test ideas through experiment."; answer[32, 1] = "He proved that Copernicus was right."; answer[32, 2] = "He invented the telescope."; answer[32, 3] = "He invented modern Astronomy."; questiontype[32] = QuestionType.MultipleChoice;
            question[33] = "Could you distinguish between Earth and Sun-centered solar system models by " + Environment.NewLine +
                "observing Venus with a telescope?"; answer[33, 0] = "Yes, in one model apparent size is correlated with phases."; answer[33, 1] = "Yes, it would show phases."; answer[33, 2] = "No, either model shows phases."; answer[33, 3] = "No, both make similar predictions."; questiontype[33] = QuestionType.MultipleChoice;
            question[34] = "Suppose a comet had a very eccentric orbit that brought it quite " + Environment.NewLine +
                "close to the Sun at closest approach (perihelion) and beyond Mars when furthest " + Environment.NewLine +
                "from the Sun (aphelion), but with an average distance of 1 AU. How long would it " + Environment.NewLine +
                "take to complete an orbit and where would it spend most of its time?"; answer[34, 0] = "One year, mostly beyond Earth's orbit."; answer[34, 1] = "One year, mostly within Earth's orbit."; answer[34, 2] = "More than one year, mostly beyond Earth's orbit."; answer[34, 3] = "Less than one year, mostly within Earth's orbit."; questiontype[34] = QuestionType.MultipleChoice;
            question[35] = "Which of the following statements is true?"; answer[35, 0] = "A circle is an example of an ellipse."; answer[35, 1] = "An ellipse is an example of a circle."; answer[35, 2] = ""; answer[35, 3] = ""; questiontype[35] = QuestionType.TrueOrFalse;
            question[36] = "Consider two asteroids in the inner solar system, one which orbits at " + Environment.NewLine +
                "an average distance of 3 AU and one which orbits at an average distance of 4 AU. Also " + Environment.NewLine +
                "consider two comets in the outer solar system, one which orbits at an average distance " + Environment.NewLine +
                "of 31 AU and one that orbits at an average distance of 32 AU. Which pair will have the " + Environment.NewLine +
                "larger difference in orbital speeds?"; answer[36, 0] = "The asteroids."; answer[36, 1] = "The comets."; answer[36, 2] = "They difference in orbital speeds will be the same for each pair."; answer[36, 3] = "We need to know the eccentricities of each object."; questiontype[36] = QuestionType.MultipleChoice;
            question[37] = "In science, saying that something is a theory means that it is really just a guess."; answer[37, 0] = "No, a hypothesis only becomes a scientific " + Environment.NewLine +
                "theory after it has been well tested."; answer[37, 1] = "Yes, but a guess by a highly educated person."; answer[37, 2] = "Yes, but it has strong support by other scientists."; answer[37, 3] = "No, it must have detailed mathematical equations " + Environment.NewLine +
                "to back it up."; questiontype[37] = QuestionType.MultipleChoice;
            question[38] = "Upon its publication in 1543, the Copernican model was immediately accepted " + Environment.NewLine +
                "by most scientists because its predictions of planetary positions were " + Environment.NewLine +
                "essentially correct."; answer[38, 0] = "No, it was not substantially more accurate than the " + Environment.NewLine +
                "Ptolemaic model."; answer[38, 1] = "Yes, because there was a growing recognition that the " + Environment.NewLine +
                "Ptolemaic model was inaccurate."; answer[38, 2] = "Yes, and it was subsequently used by navigators to explore " + Environment.NewLine +
                "the New World."; answer[38, 3] = "Yes, and it was therefore subsequently referred to as the " + Environment.NewLine +
                "Copernican revolution."; questiontype[38] = QuestionType.MultipleChoice;
            question[39] = "Only one of the statements below uses the term theory in its correct, " + Environment.NewLine +
                "scientific sense. Which one?"; answer[39, 0] = "Einstein's theory of relativity has been tested and verified thousands of times."; answer[39, 1] = "I have a new theory about the cause of earthquakes, and I plan to start testing it soon."; answer[39, 2] = "I wrote a theory that is 152 pages long."; answer[39, 3] = "Evolution is only a theory, so there's no reason to think it really happened."; questiontype[39] = QuestionType.MultipleChoice;
            question[40] = "Process of Science: If any single test of a scientific hypothesis contradicts it, the hypothesis " + Environment.NewLine +
            "must be revised. (Assume that you've ruled out errors in the testing process; that is, the test " + Environment.NewLine +
            "result really does contradict the hypothesis.)"; answer[40, 0] = "True"; answer[40, 1] = "False"; answer[40, 2] = ""; answer[40, 3] = ""; questiontype[40] = QuestionType.TrueOrFalse;
            question[41] = "According to Kepler's third law (p^2 = a^3), how does a planet's mass affect its " + Environment.NewLine +
                "orbit around the Sun? "; answer[41, 0] = "A planet's mass has no effect on its orbit around the Sun."; answer[41, 1] = "More massive planets orbit the Sun at higher average speed."; answer[41, 2] = "More massive planets must have more circular orbits. "; answer[41, 3] = "A more massive planet must have a larger semimajor axis."; questiontype[41] = QuestionType.MultipleChoice;
            question[42] = "He discovered that Jupiter has moons."; answer[42, 0] = "Galileo."; answer[42, 1] = "Aristotle."; answer[42, 2] = "Ptolemy."; answer[42, 3] = "Kepler."; questiontype[42] = QuestionType.MultipleChoice;
            question[43] = "From Kepler's third law, an asteroid with an orbital period of 8 years lies at an " + Environment.NewLine +
                "average distance from the Sun equal to "; answer[43, 0] = "4 astronomical units."; answer[43, 1] = "2 astronomical units."; answer[43, 2] = "8 astronomical units."; answer[43, 3] = "16 astronomical units."; questiontype[43] = QuestionType.MultipleChoice;
            question[44] = "How did the Ptolemaic model explain the apparent retrograde motion of the planets?"; answer[44, 0] = "It held that the planets moved along small circles " + Environment.NewLine +
                "that moved on larger circles around Earth."; answer[44, 1] = "It placed the Sun at the center so that the planets' " + Environment.NewLine +
                "apparent retrograde motion was seen as Earth passed each one in its orbit."; answer[44, 2] = "It held that the planets moved along small circles that moved " + Environment.NewLine +
                "on larger circles around the Sun."; answer[44, 3] = "It held that sometimes the planets moved backward along their " + Environment.NewLine +
                "circular orbits."; questiontype[44] = QuestionType.MultipleChoice;
            question[45] = "A scientific model must make a testable prediction."; answer[45, 0] = "True"; answer[45, 1] = "False"; answer[45, 2] = ""; answer[45, 3] = ""; questiontype[45] = QuestionType.TrueOrFalse;
            question[46] = "Kepler's third law, p^2 =  a^3, means that "; answer[46, 0] = "All of the above are correct."; answer[46, 1] = "the period of a planet does not depend on its mass."; answer[46, 2] = "A planet's period does not depend on the eccentricity of its orbit."; answer[46, 3] = "All orbits with the same semimajor axis have the same period."; questiontype[46] = QuestionType.MultipleChoice;
            question[47] = "All the following statements are true. Which one follows directly from Kepler's third law?"; answer[47, 0] = "Venus orbits the Sun at a slower average speed than Mercury."; answer[47, 1] = "Venus is more massive than Mercury."; answer[47, 2] = "Venus is larger than Mercury."; answer[47, 3] = "Venus has a thicker atmosphere than Mercury."; questiontype[47] = QuestionType.MultipleChoice;
            question[48] = "He was the first to prove that comets lie beyond Earth's atmosphere."; answer[48, 0] = "Tycho Brahe."; answer[48, 1] = "Copernicus."; answer[48, 2] = "Kepler."; answer[48, 3] = "Galileo."; questiontype[48] = QuestionType.MultipleChoice;

            order = new int[numberOfQuestions];
            randomOrder = new int[numberOfQuestions];

            for (int i = 0; i < numberOfQuestions; i++)
            {
                order[i] = i;
                randomOrder[i] = i;
            }
        }

        public Chapter3()
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
