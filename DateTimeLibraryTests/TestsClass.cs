using DateTimeLibrary;
using NUnit.Framework;
using System;

namespace DateTimeLibraryTests
{
    public class DateTimeUtilsTests
    {
        [Test]
        public void TestGetDateDifference()
        {
            DateTime date1 = new DateTime(2022, 1, 1);
            DateTime date2 = new DateTime(2022, 1, 10);
            TimeSpan difference = DateTimeClass.GetDateDifference(date1, date2);
            Assert.That(difference.TotalDays, Is.EqualTo(9));
        }

        [Test]
        public void TestIsLeapYear()
        {
            Assert.That(DateTimeClass.IsLeapYear(2020), Is.True);
            Assert.That(DateTimeClass.IsLeapYear(2021), Is.False);
        }

        [Test]
        public void TestGetTimeOfDay()
        {
            DateTime morning = new DateTime(2022, 1, 1, 8, 0, 0);
            DateTime afternoon = new DateTime(2022, 1, 1, 14, 0, 0);
            DateTime evening = new DateTime(2022, 1, 1, 20, 0, 0);

            Assert.That(DateTimeClass.GetTimeOfDay(morning), Is.EqualTo("Morning"));
            Assert.That(DateTimeClass.GetTimeOfDay(afternoon), Is.EqualTo("Afternoon"));
            Assert.That(DateTimeClass.GetTimeOfDay(evening), Is.EqualTo("Evening"));
        }

        [Test]
        public void TestFormatDateTime()
        {
            DateTime dateTime = new DateTime(2022, 1, 1, 12, 30, 0);
            Assert.That(DateTimeClass.FormatDateTime(dateTime), Is.EqualTo("2022-01-01 12:30:00"));
        }
    }
}