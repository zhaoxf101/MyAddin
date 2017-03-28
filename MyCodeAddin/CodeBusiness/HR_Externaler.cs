using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Externaler))]
#if Dev
    [RunLocal]
#endif

	public class HR_Externaler:ReadOnlyBase<HR_Externaler>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExternalNo
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string ExternalName
        {
            get ;
            set ;
        }

		
        public string IDCardTypeCode
        {
            get ;
            set ;
        }

		
        public string IDCardNo
        {
            get ;
            set ;
        }

		
        public string Sex
        {
            get ;
            set ;
        }

		
        public string Country
        {
            get ;
            set ;
        }

		
        public string Nation
        {
            get ;
            set ;
        }

		
        public string Hometown
        {
            get ;
            set ;
        }

		
        public DateTime? Birth
        {
            get ;
            set ;
        }

		
        public string Addr
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary Photo
        {
            get ;
            set ;
        }

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string MobTel
        {
            get ;
            set ;
        }

		
        public string Email
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool OneTime
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static HR_Externaler Create()
        {
            return EF.DataPortal.Create<HR_Externaler>();
        }

		public static HR_Externaler Fetch(System.Linq.Expressions.Expression<Func<HR_Externaler, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Externaler>(exp,values);
            return EF.DataPortal.Fetch<HR_Externaler>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Externalers))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Externalers:ReadOnlyListBase<HR_Externalers,HR_Externaler>
    {
        #region Factory Methods

        public static HR_Externalers Fetch()
        {
            return EF.DataPortal.Fetch<HR_Externalers>();
        }

		public static HR_Externalers Fetch(System.Linq.Expressions.Expression<Func<HR_Externaler, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Externaler>(exp,values);
            return EF.DataPortal.Fetch<HR_Externalers>(lambda);
		}

		public static HR_Externalers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Externalers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Externalers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Externaler, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Externalers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Externaler>(exp,values)});
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
