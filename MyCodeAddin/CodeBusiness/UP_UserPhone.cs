using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_UserPhone))]
#if Dev
    [RunLocal]
#endif

	public class UP_UserPhone:ReadOnlyBase<UP_UserPhone>
    {
        #region Business Methods

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string UserCode
        {
            get ;
            set ;
        }

		
        public string PhoneMac
        {
            get ;
            set ;
        }

		
        public DateTime? LoginTime
        {
            get ;
            set ;
        }

		
        public string AndroidVersion
        {
            get ;
            set ;
        }

		
        public string PhoneModel
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_UserPhone Create()
        {
            return EF.DataPortal.Create<UP_UserPhone>();
        }

		public static UP_UserPhone Fetch(System.Linq.Expressions.Expression<Func<UP_UserPhone, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_UserPhone>(exp,values);
            return EF.DataPortal.Fetch<UP_UserPhone>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_UserPhones))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_UserPhones:ReadOnlyListBase<UP_UserPhones,UP_UserPhone>
    {
        #region Factory Methods

        public static UP_UserPhones Fetch()
        {
            return EF.DataPortal.Fetch<UP_UserPhones>();
        }

		public static UP_UserPhones Fetch(System.Linq.Expressions.Expression<Func<UP_UserPhone, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_UserPhone>(exp,values);
            return EF.DataPortal.Fetch<UP_UserPhones>(lambda);
		}

		public static UP_UserPhones Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_UserPhones>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_UserPhones Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_UserPhone, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_UserPhones>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_UserPhone>(exp,values)});
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
