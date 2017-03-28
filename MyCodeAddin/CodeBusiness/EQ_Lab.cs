using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EQ_Lab))]
#if Dev
    [RunLocal]
#endif

	public class EQ_Lab:ReadOnlyBase<EQ_Lab>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string LabNo
        {
            get ;
            set ;
        }

		
        public string LabName
        {
            get ;
            set ;
        }

		
        public string LabLevCode
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string LPersonId
        {
            get ;
            set ;
        }

		
        public string Location
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsDel
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

		public static EQ_Lab Create()
        {
            return EF.DataPortal.Create<EQ_Lab>();
        }

		public static EQ_Lab Fetch(System.Linq.Expressions.Expression<Func<EQ_Lab, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EQ_Lab>(exp,values);
            return EF.DataPortal.Fetch<EQ_Lab>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EQ_Labs))]
#if Dev
    [RunLocal]
#endif
	
	public class EQ_Labs:ReadOnlyListBase<EQ_Labs,EQ_Lab>
    {
        #region Factory Methods

        public static EQ_Labs Fetch()
        {
            return EF.DataPortal.Fetch<EQ_Labs>();
        }

		public static EQ_Labs Fetch(System.Linq.Expressions.Expression<Func<EQ_Lab, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EQ_Lab>(exp,values);
            return EF.DataPortal.Fetch<EQ_Labs>(lambda);
		}

		public static EQ_Labs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EQ_Labs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EQ_Labs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EQ_Lab, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EQ_Labs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EQ_Lab>(exp,values)});
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
