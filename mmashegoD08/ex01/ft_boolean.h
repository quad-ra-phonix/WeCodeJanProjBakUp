/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_boolean.h                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mmashego <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/02/12 10:30:50 by mmashego          #+#    #+#             */
/*   Updated: 2016/02/12 10:50:54 by mmashego         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <unistd.h>

#define TRUE	1
#define FALSE	0
#define SUCCESS	0
#define EVEN_MSG "I have an even number of arguements.\n"
#define ODD_MSG	"I have an odd number of arguments.\n"
#define EVEN(x)	(!((x) % 2))

typedef int t_bool;	
