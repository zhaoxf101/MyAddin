using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Person))]
#if Dev
    [RunLocal]
#endif

	public class HR_Person:ReadOnlyBase<HR_Person>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string PersonName
        {
            get ;
            set ;
        }

		
        public string UType
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

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static HR_Person Create()
        {
            return EF.DataPortal.Create<HR_Person>();
        }

		public static HR_Person Fetch(System.Linq.Expressions.Expression<Func<HR_Person, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Person>(exp,values);
            return EF.DataPortal.Fetch<HR_Person>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Persons))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Persons:ReadOnlyListBase<HR_Persons,HR_Person>
    {
        #region Factory Methods

        public static HR_Persons Fetch()
        {
            return EF.DataPortal.Fetch<HR_Persons>();
        }

		public static HR_Persons Fetch(System.Linq.Expressions.Expression<Func<HR_Person, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Person>(exp,values);
            return EF.DataPortal.Fetch<HR_Persons>(lambda);
		}

		public static HR_Persons Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Persons>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Persons Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Person, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Persons>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Person>(exp,values)});
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
