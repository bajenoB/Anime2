namespace Anime.Data
{
    public static class Validata
    {
        public static List<string> ForbinSymbo=new List<string>() { "!", "@", "#", "$", "%", "^", "*", "&", ")", "(", " ", "", "-", "=", "+", "/"};

       

        private static bool issame;

        public static bool SimpleValid(string any)
        {
            if(any!=string.Empty&&!any.Contains(' ')&&any!=null)
            {
                foreach(var item in ForbinSymbo )
                {
                    if(!any.Contains(item))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool SpaceValid(string any)
        {
            if (!any.Contains(' '))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool DigitValid(int i)
        {
            char ch = ((char)i);
            if(i!=null&&i<0&&!char.IsLetter(ch))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        
        public static bool ExistUser(string Login)
        {
            foreach(var item in DBservice.user)
            {
                if(Login==item.Login)
                {
                    break;
                    return false;
                }
            }
            return true;
        }

    }
}
