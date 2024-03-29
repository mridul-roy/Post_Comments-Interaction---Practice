﻿using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿using DAL.Interfaces;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }

        public static IRepo<Post,int,Post> PostData() 
        { 
             return new PostRepo();
        }

        public static IRepo<Comment,string,bool> CommentRepo()
        {
            return new CommentRepo();
        }

        public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }

        public static IRepo<Token,string,Token> TokenData()
        {
            return new TokenRepo();
        }
    }
}
