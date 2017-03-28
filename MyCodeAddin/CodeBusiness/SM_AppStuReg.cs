using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_AppStuReg))]
#if Dev
    [RunLocal]
#endif

	public class SM_AppStuReg:ReadOnlyBase<SM_AppStuReg>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AppNo
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string SDate
        {
            get ;
            set ;
        }

		
        public string EDate
        {
            get ;
            set ;
        }

		
        public string RegCode
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

		public static SM_AppStuReg Create()
        {
            return EF.DataPortal.Create<SM_AppStuReg>();
        }

		public static SM_AppStuReg Fetch(System.Linq.Expressions.Expression<Func<SM_AppStuReg, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStuReg>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStuReg>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_AppStuRegs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_AppStuRegs:ReadOnlyListBase<SM_AppStuRegs,SM_AppStuReg>
    {
        #region Factory Methods

        public static SM_AppStuRegs Fetch()
        {
            return EF.DataPortal.Fetch<SM_AppStuRegs>();
        }

		public static SM_AppStuRegs Fetch(System.Linq.Expressions.Expression<Func<SM_AppStuReg, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStuReg>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStuRegs>(lambda);
		}

		public static SM_AppStuRegs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_AppStuRegs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_AppStuRegs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_AppStuReg, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_AppStuRegs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_AppStuReg>(exp,values)});
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
