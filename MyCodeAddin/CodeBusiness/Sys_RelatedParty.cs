using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_RelatedParty))]
#if Dev
    [RunLocal]
#endif

	public class Sys_RelatedParty:ReadOnlyBase<Sys_RelatedParty>
    {
        #region Business Methods

		
        public string RelPartyCode
        {
            get ;
            set ;
        }

		
        public string RelPartyName
        {
            get ;
            set ;
        }

		
        public string RelPartyGrpCode
        {
            get ;
            set ;
        }

		
        public bool OneTimeX
        {
            get ;
            set ;
        }

		
        public string Title
        {
            get ;
            set ;
        }

		
        public string IndexKey
        {
            get ;
            set ;
        }

		
        public string IDCode
        {
            get ;
            set ;
        }

		
        public string City
        {
            get ;
            set ;
        }

		
        public string Address
        {
            get ;
            set ;
        }

		
        public string Telphone
        {
            get ;
            set ;
        }

		
        public string Email
        {
            get ;
            set ;
        }

		
        public bool IsDelete
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_RelatedParty Create()
        {
            return EF.DataPortal.Create<Sys_RelatedParty>();
        }

		public static Sys_RelatedParty Fetch(System.Linq.Expressions.Expression<Func<Sys_RelatedParty, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_RelatedParty>(exp,values);
            return EF.DataPortal.Fetch<Sys_RelatedParty>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_RelatedPartys))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_RelatedPartys:ReadOnlyListBase<Sys_RelatedPartys,Sys_RelatedParty>
    {
        #region Factory Methods

        public static Sys_RelatedPartys Fetch()
        {
            return EF.DataPortal.Fetch<Sys_RelatedPartys>();
        }

		public static Sys_RelatedPartys Fetch(System.Linq.Expressions.Expression<Func<Sys_RelatedParty, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_RelatedParty>(exp,values);
            return EF.DataPortal.Fetch<Sys_RelatedPartys>(lambda);
		}

		public static Sys_RelatedPartys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_RelatedPartys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_RelatedPartys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_RelatedParty, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_RelatedPartys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_RelatedParty>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
