using CardClass;

namespace UserClass
{
    public enum UserStatus
    {
        NoAction,
        Bet,
        AllIn,
        Check,
        Raise,
        Call
    }

    public class UserClass
    {
        public bool Parent
        {
            get;
            set;
        }

        public bool SemiParent
        {
            get;
            set;
        }

        private Card[] UserCards 
        { 
            get; 
            set; 
        }

        private int OwnMoney
        {
            get;
            set;
        }

        private int BetMoney
        {
            get;
            set;
        }

        public UserStatus status
        {
            get;
            set;
        }

        public UserClass(bool is_parent, bool is_semi_parent, int ownmoney)
        {
            Parent = is_parent;
            SemiParent = is_semi_parent;
            UserCards = [];
            OwnMoney = ownmoney;
            BetMoney = 0;
            status = UserStatus.NoAction;
        }
    }
}