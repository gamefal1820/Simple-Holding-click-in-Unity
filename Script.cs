	public static bool Holding(float holdTime)
	{
		if (Input.GetMouseButtonDown(0)) startTime = Time.time;

		if (Input.GetMouseButtonUp(0) || !Input.GetMouseButton(0))
		{
			startTime = 0;
		}
		else if (Time.time - startTime > holdTime)
		{
			return true;
		}
		return false;
	}
