USE [glass]
GO

	SELECT 'Итого:' as good_marking,Sum(view_modelcalc.qustore * view_orderitem.qu) as qustore FROM view_modelcalc	
	
	JOIN view_orderitem ON view_orderitem.idorderitem = view_modelcalc.idorderitem

	UNION
	SELECT  view_modelcalc.good_marking, Sum(view_modelcalc.qustore * view_orderitem.qu) FROM view_modelcalc	

	JOIN view_orderitem ON view_orderitem.idorderitem = view_modelcalc.idorderitem


	GROUP BY view_modelcalc.good_marking 
GO