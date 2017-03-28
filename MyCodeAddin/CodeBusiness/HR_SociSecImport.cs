using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SociSecImport))]
#if Dev
    [RunLocal]
#endif

	public class HR_SociSecImport:ReadOnlyBase<HR_SociSecImport>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SociSecCode
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public string ModeCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public bool IsConf
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public bool IsHaveTax
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

		public static HR_SociSecImport Create()
        {
            return EF.DataPortal.Create<HR_SociSecImport>();
        }

		public static HR_SociSecImport Fetch(System.Linq.Expressions.Expression<Func<HR_SociSecImport, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SociSecImport>(exp,values);
            return EF.DataPortal.Fetch<HR_SociSecImport>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SociSecImports))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SociSecImports:ReadOnlyListBase<HR_SociSecImports,HR_SociSecImport>
    {
        #region Factory Methods

        public static HR_SociSecImports Fetch()
        {
            return EF.DataPortal.Fetch<HR_SociSecImports>();
        }

		public static HR_SociSecImports Fetch(System.Linq.Expressions.Expression<Func<HR_SociSecImport, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SociSecImport>(exp,values);
            return EF.DataPortal.Fetch<HR_SociSecImports>(lambda);
		}

		public static HR_SociSecImports Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SociSecImports>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SociSecImports Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SociSecImport, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SociSecImports>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SociSecImport>(exp,values)});
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
