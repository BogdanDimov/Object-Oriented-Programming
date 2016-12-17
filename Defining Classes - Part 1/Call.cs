using System;

namespace Defining_Classes___Part_1
{
    class Call
    {
        public DateTime Time { get; set; } = new DateTime(2016, 12, 16);
        public string PhoneNumber { get; set; } = "0800123654";
        public TimeSpan Duration { get; set; } = new TimeSpan(0, 5, 30);

        public Call(DateTime time, string phoneNumber, TimeSpan duration)
        {
            Time = time;
            PhoneNumber = phoneNumber;
            Duration = duration;
        }

        public override string ToString()
        {
            return string.Format($"Dialed number: {PhoneNumber}\nTime of call: {Time.ToString("dd.MM.yyyy HH:mm")}\nDuration: {Duration.TotalSeconds} sec");
        }
    }
}
