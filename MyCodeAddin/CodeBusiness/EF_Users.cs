using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_Users))]
#if Dev
    [RunLocal]
#endif

	public class EF_Users:ReadOnlyBase<EF_Users>
    {
        #region Business Methods

		
        public string BName
        {
            get ;
            set ;
        }

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TName
        {
            get ;
            set ;
        }

		
        public string Address
        {
            get ;
            set ;
        }

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string EMail
        {
            get ;
            set ;
        }

		
        public string UType
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string MerchantNo
        {
            get ;
            set ;
        }

		
        public string ShopCode
        {
            get ;
            set ;
        }

		
        public string PassCode
        {
            get ;
            set ;
        }

		
        public DateTime? ValidFrom
        {
            get ;
            set ;
        }

		
        public DateTime? ValidTo
        {
            get ;
            set ;
        }

		
        public string UserGroup
        {
            get ;
            set ;
        }

		
        public bool ULocked
        {
            get ;
            set ;
        }

		
        public string CRName
        {
            get ;
            set ;
        }

		
        public DateTime? CRDate
        {
            get ;
            set ;
        }

		
        public string LastUser
        {
            get ;
            set ;
        }

		
        public DateTime? LastDate
        {
            get ;
            set ;
        }

		
        public DateTime? LoginDate
        {
            get ;
            set ;
        }

		
        public DateTime? PwdChgDate
        {
            get ;
            set ;
        }

		
        public bool PwdInitial
        {
            get ;
            set ;
        }

		
        public string DateFM
        {
            get ;
            set ;
        }

		
        public string DcpFM
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_Users Create()
        {
            return EF.DataPortal.Create<EF_Users>();
        }

		public static EF_Users Fetch(System.Linq.Expressions.Expression<Func<EF_Users, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_Users>(exp,values);
            return EF.DataPortal.Fetch<EF_Users>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_Userss))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_Userss:ReadOnlyListBase<EF_Userss,EF_Users>
    {
        #region Factory Methods

        public static EF_Userss Fetch()
        {
            return EF.DataPortal.Fetch<EF_Userss>();
        }

		public static EF_Userss Fetch(System.Linq.Expressions.Expression<Func<EF_Users, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_Users>(exp,values);
            return EF.DataPortal.Fetch<EF_Userss>(lambda);
		}

		public static EF_Userss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_Userss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_Userss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_Users, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_Userss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_Users>(exp,values)});
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
