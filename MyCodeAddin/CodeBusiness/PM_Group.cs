using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_Group))]
#if Dev
    [RunLocal]
#endif

	public class PM_Group:ReadOnlyBase<PM_Group>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjGrpCode
        {
            get ;
            set ;
        }

		
        public string ProjGrpName
        {
            get ;
            set ;
        }

		
        public bool IsPublic
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

		public static PM_Group Create()
        {
            return EF.DataPortal.Create<PM_Group>();
        }

		public static PM_Group Fetch(System.Linq.Expressions.Expression<Func<PM_Group, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_Group>(exp,values);
            return EF.DataPortal.Fetch<PM_Group>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_Groups))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_Groups:ReadOnlyListBase<PM_Groups,PM_Group>
    {
        #region Factory Methods

        public static PM_Groups Fetch()
        {
            return EF.DataPortal.Fetch<PM_Groups>();
        }

		public static PM_Groups Fetch(System.Linq.Expressions.Expression<Func<PM_Group, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_Group>(exp,values);
            return EF.DataPortal.Fetch<PM_Groups>(lambda);
		}

		public static PM_Groups Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_Groups>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_Groups Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_Group, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_Groups>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_Group>(exp,values)});
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
