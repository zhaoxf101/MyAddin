using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_MoveType))]
#if Dev
    [RunLocal]
#endif

	public class MM_MoveType:ReadOnlyBase<MM_MoveType>
    {
        #region Business Methods

		
        public string MoveType
        {
            get ;
            set ;
        }

		
        public string IsBD
        {
            get ;
            set ;
        }

		
        public string KZWES
        {
            get ;
            set ;
        }

		
        public string KZVBU
        {
            get ;
            set ;
        }

		
        public string KZDRU
        {
            get ;
            set ;
        }

		
        public string KZKON
        {
            get ;
            set ;
        }

		
        public string CHNEU
        {
            get ;
            set ;
        }

		
        public string KZZDE
        {
            get ;
            set ;
        }

		
        public string RSTYP
        {
            get ;
            set ;
        }

		
        public string SELPA
        {
            get ;
            set ;
        }

		
        public string XLAUT
        {
            get ;
            set ;
        }

		
        public string KZSTR
        {
            get ;
            set ;
        }

		
        public string KZGRU
        {
            get ;
            set ;
        }

		
        public string XINVB
        {
            get ;
            set ;
        }

		
        public string QSSBW
        {
            get ;
            set ;
        }

		
        public string KZBWA
        {
            get ;
            set ;
        }

		
        public string XSTBW
        {
            get ;
            set ;
        }

		
        public string XPBED
        {
            get ;
            set ;
        }

		
        public string XWSBR
        {
            get ;
            set ;
        }

		
        public string KZMHD
        {
            get ;
            set ;
        }

		
        public string KZCLA
        {
            get ;
            set ;
        }

		
        public string XKOKO
        {
            get ;
            set ;
        }

		
        public string XKCFC
        {
            get ;
            set ;
        }

		
        public string XNEBE
        {
            get ;
            set ;
        }

		
        public string J_1BNFREL
        {
            get ;
            set ;
        }

		
        public string J_1BNFTYPE
        {
            get ;
            set ;
        }

		
        public string J_1BITMTYP
        {
            get ;
            set ;
        }

		
        public string J_1BSPCSTO
        {
            get ;
            set ;
        }

		
        public string J_1BPARTYP
        {
            get ;
            set ;
        }

		
        public string J_1BPARVW
        {
            get ;
            set ;
        }

		
        public string RULES
        {
            get ;
            set ;
        }

		
        public string J_1AREVIDX
        {
            get ;
            set ;
        }

		
        public string J_1ADOCCL
        {
            get ;
            set ;
        }

		
        public string J_1AEXPKZ
        {
            get ;
            set ;
        }

		
        public string XOARC
        {
            get ;
            set ;
        }

		
        public string BUSTR
        {
            get ;
            set ;
        }

		
        public string KZDIR
        {
            get ;
            set ;
        }

		
        public string OIJ1BNFFI
        {
            get ;
            set ;
        }

		
        public string MILL_CPCONF
        {
            get ;
            set ;
        }

		
        public string LText
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

		public static MM_MoveType Create()
        {
            return EF.DataPortal.Create<MM_MoveType>();
        }

		public static MM_MoveType Fetch(System.Linq.Expressions.Expression<Func<MM_MoveType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_MoveType>(exp,values);
            return EF.DataPortal.Fetch<MM_MoveType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_MoveTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_MoveTypes:ReadOnlyListBase<MM_MoveTypes,MM_MoveType>
    {
        #region Factory Methods

        public static MM_MoveTypes Fetch()
        {
            return EF.DataPortal.Fetch<MM_MoveTypes>();
        }

		public static MM_MoveTypes Fetch(System.Linq.Expressions.Expression<Func<MM_MoveType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_MoveType>(exp,values);
            return EF.DataPortal.Fetch<MM_MoveTypes>(lambda);
		}

		public static MM_MoveTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_MoveTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_MoveTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_MoveType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_MoveTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_MoveType>(exp,values)});
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
