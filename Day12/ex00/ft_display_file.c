/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_display_file.c                                  :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/18 14:22:43 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/18 14:31:48 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>
#include <fcntl.h>

void		disp_file(int fd)
{
			char	buff;

			while (read(fd, &buff, 1) != 0)
				write(1, &buff, 1);
}

int			main(int argc, char **argv)
{
		int		fd;

		if (argc !=2)
		{
			if (argc > 2)
				write(2, "Too many arguments.\n", 20);
			if (argc < 2)
				write(2, "file name missing.\n", 19);
			return (1);
		}
		fd = open(argv[1], O_RDONLY);
		disp_file(fd);
		close(fd);
		return (0);
}
