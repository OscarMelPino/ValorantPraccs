using System;

namespace Lib.COR
{
    public class Matches
    {
        public virtual int MatchID { get; set; }
        public virtual int MapID { get; set; }
        public virtual DateTime MatchDate { get; set; }
        public virtual int Winner { get; set; }
        public virtual int TeamA { get; set; }
        public virtual int TeamB { get; set; }
        public virtual string Result { get; set; }
    }
}
